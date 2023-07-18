using Esports.Data.Helpers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public Task ConvertToImageAsync()
        {
            throw new NotImplementedException();
        }
    }
}
