namespace MusicHub
{
    using System;
    using System.Text;
    using Data;
    using MusicHub.Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();
            DbInitializer.ResetDatabase(context);

            Console.WriteLine(ExportAlbumsInfo(context, 9));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            
            StringBuilder sb = new StringBuilder();
            using (context)
            {
                var albums = context.Albums
                    .Where(x => x.Producer.Id == producerId)
                    .ToList();
                foreach (var item in albums.OrderByDescending(x => x.Price))
                {
                    int i = 0;
                    sb.AppendLine($"-AlbumName: {item.Name}");
                    sb.AppendLine($"-ReleaseDate: {item.ReleaseDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)}");
                    sb.AppendLine($"-ProducerName: {item.Producer.Name}");
                    sb.AppendLine($"-Songs:");

                    foreach (var song in item.Songs.OrderByDescending(x => x.Name).ThenBy(x => x.Writer.Name))
                    {
                        i++;
                        sb.AppendLine($"---#{i}");
                        sb.AppendLine($"---SongName: {song.Name}");
                        sb.AppendLine($"---Price: {song.Price.ToString("0.00")}");
                        sb.AppendLine($"---Writer: {song.Writer.Name}");
                    }
                    sb.AppendLine($"-AlbumPrice: {item.Price.ToString("0.00")}");
                }

                
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}
