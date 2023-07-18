using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esports.Data.Helpers.Contracts
{
    public interface IImageConverter
    {
        public byte[] ConvertToByteArray(string path);
        public Task ConvertToImageAsync();
    }
}
