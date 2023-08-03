using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Helpers.Contracts
{
    public interface IImageConverter
    {
        public Task<byte[]> ConvertToByteArrayAsync(string path);
        public string ConvertToImage(byte[] arr);
    }
}
