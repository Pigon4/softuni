namespace Boardgames.DataProcessor
{
    using System.ComponentModel.DataAnnotations;
    using Boardgames.DataProcessor;
    using Boardgames.Data;
    using Boardgames.Data.Models.Enums;
    using System.Text;
    using Boardgames.DataProcessor.ImportDto;
    using Boardgames.Data.Models;
    using Microsoft.IdentityModel.JsonWebTokens;
    using Newtonsoft.Json;
    using System.Collections;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfullyImportedCreator
            = "Successfully imported creator – {0} {1} with {2} boardgames.";

        private const string SuccessfullyImportedSeller
            = "Successfully imported seller - {0} with {1} boardgames.";

        public static string ImportCreators(BoardgamesContext context, string xmlString)
        {
            XmlHelper xmlHelper = new XmlHelper();
            StringBuilder sb = new StringBuilder();

            ImportCreatorsDto[] creators = xmlHelper.Deserialize<ImportCreatorsDto[]>(xmlString, "Creators");

            ICollection<Creator> valid = new HashSet<Creator>();
            foreach (var creator in creators)
            {
                if (!IsValid(creator))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                ICollection<Boardgame> validGames = new HashSet<Boardgame>();
                foreach (var game in creator.Boardgames)
                {
                    if (!IsValid(game))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    Boardgame boardgame = new Boardgame()
                    {
                        Name = game.Name,
                        Rating = game.Rating,
                        YearPublished = game.YearPublished,
                        CategoryType = (CategoryType)game.CategoryType,
                        Mechanics = game.Mechanics
                    };


                    validGames.Add(boardgame);
                }

                Creator creator1 = new Creator()
                {
                    FirstName = creator.FirstName,
                    LastName = creator.LastName,
                    Boardgames = validGames
                };
                valid.Add(creator1);
                sb.AppendLine(String.Format(SuccessfullyImportedCreator,creator1.FirstName,creator1.LastName,creator1.Boardgames.Count));
            }

            context.Creators.AddRange(valid);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        public static string ImportSellers(BoardgamesContext context, string jsonString)
        {
            StringBuilder sb = new StringBuilder();
            ImportSellerDto[] sellers = JsonConvert.DeserializeObject<ImportSellerDto[]>(jsonString);

            ICollection<Seller> valid = new HashSet<Seller>();
            ICollection<int> validIds = context.Boardgames
                .Select(x => x.Id)
                .ToArray();
            foreach (var sellersDto in sellers)
            {
                if (!IsValid(sellersDto))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }
                Seller seller = new Seller()
                {
                    Name = sellersDto.Name,
                    Address = sellersDto.Address,
                    Country = sellersDto.Country,
                    Website = sellersDto.Website,
                    BoardgamesSellers = new HashSet<BoardgameSeller>()

                };

                foreach (var item in sellersDto.Boardgames.Distinct())
                {
                    if (!validIds.Contains(item))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }
                    BoardgameSeller bs = new BoardgameSeller()
                    {
                        Seller = seller,
                        BoardgameId = item
                    };

                    seller.BoardgamesSellers.Add(bs);
                }

                valid.Add(seller);
                sb.AppendLine(String.Format(SuccessfullyImportedSeller, seller.Name, seller.BoardgamesSellers.Count));
                
            }

            context.AddRange(valid);
            context.SaveChanges();

            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}
