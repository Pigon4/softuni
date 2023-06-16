using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playerdle.Infrastructure.BusinessLogic.Contracts
{
    public interface IImageConverter
    {
        public byte[] ConvertImageToByteArray();
    }
}
