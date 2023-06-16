using Playerdle.Infrastructure.BusinessLogic.Contracts;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Playerdle.Infrastructure.BusinessLogic
{
    public class ImageConverter : IImageConverter
    {
        public byte[] ConvertImageToByteArray()
        {
            byte[] bytes;

            bytes = File.ReadAllBytes("..\\fnatic.png"); 

            return  bytes;
        }

    }
}
