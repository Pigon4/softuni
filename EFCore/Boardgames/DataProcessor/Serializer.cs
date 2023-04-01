namespace Boardgames.DataProcessor
{
    using Boardgames.Data;
    using Boardgames.Data.Models.Enums;
    using Boardgames.DataProcessor.ExportDto;
    using Microsoft.EntityFrameworkCore;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    public class Serializer
    {
        public static string ExportCreatorsWithTheirBoardgames(BoardgamesContext context)
        {
            XmlRootAttribute xmlRoot =
                new XmlRootAttribute("Creators");
            XmlSerializer xmlSerializer =
                new XmlSerializer(typeof(ExportCreatorDto[]), xmlRoot);
            StringBuilder sb = new StringBuilder();
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            ExportCreatorDto[] creators = context.Creators
                .ToArray()
                .Where(x => x.Boardgames.Any())
                .Select(c => new ExportCreatorDto()
                {
                    CreatorName = c.FirstName + " " + c.LastName,
                    Count = c.Boardgames.Count(),
                    Boardgames = c.Boardgames
                    .Select(x => new ExportBoardgameDto()
                    {
                        BoardgameName = x.Name,
                        YearPublished = x.YearPublished
                    }).OrderBy(n => n.BoardgameName)
                    .ToArray()

                }).OrderByDescending(x => x.Count)
                .ThenBy(x => x.CreatorName)
                .ToArray();

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            using XmlWriter writer = XmlWriter.Create(sb, settings);
            xmlSerializer.Serialize(writer, creators, namespaces);
            return sb.ToString().TrimEnd();
        }

        public static string ExportSellersWithMostBoardgames(BoardgamesContext context, int year, double rating)
        {
            var sellers = context.Sellers
                .Include(bs => bs.BoardgamesSellers)
                .ThenInclude(b => b.Boardgame)
                .AsNoTracking()
                .ToArray()
                .Where(x => x.BoardgamesSellers.Any(x => x.Boardgame.YearPublished >= year && x.Boardgame.Rating <= rating))
                .Select(x => new
                {
                    Name = x.Name,
                    Website = x.Website,
                    Boardgames = x.BoardgamesSellers
                    .Where(x => x.Boardgame.YearPublished >= year && x.Boardgame.Rating <= rating)
                    .Select(x => new
                    {
                        Name = x.Boardgame.Name,
                        Rating = x.Boardgame.Rating,
                        Mechanics = x.Boardgame.Mechanics,
                        Category = x.Boardgame.CategoryType.ToString()
                    }).OrderByDescending(r => r.Rating)
                    .ThenBy(n => n.Name)
                    
                    
                    

                }).OrderByDescending(b => b.Boardgames.Count())
                .ThenBy(n => n.Name)
                .Take(5)
                .ToArray();

            
            return JsonConvert.SerializeObject(sellers, Newtonsoft.Json.Formatting.Indented);
        }
    }
}

/* .Select(x => new
                    {
                        Name = x.Boardgame.Name,
                        Rating = x.Boardgame.Rating,
                        Mechanics = x.Boardgame.Mechanics,
                        Category = x.Boardgame.CategoryType.ToString()
                    }).OrderByDescending(r => r.Rating)
                    .ThenBy(n => n.Name)*/