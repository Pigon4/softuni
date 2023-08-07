using Esports.Data.Helpers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Esports.Data.Helpers
{
    public class ImageConverter : IImageConverter
    {
        public byte[] ConvertToByteArray(string path)
        {
            byte[] arr;
            arr = File.ReadAllBytes(path);
            return arr;
        }
        public async Task<byte[]> ConvertToByteArrayAsync(string path)
        {
            byte[] arr;
            arr = await File.ReadAllBytesAsync(path);
            return arr;
        }

        public string ConvertToImage(byte[] arr)
        {
            string imreBase64Base = Convert.ToBase64String(arr);

            return string.Format("data:image/png;base64,{0}", imreBase64Base);
        }
    }
}
