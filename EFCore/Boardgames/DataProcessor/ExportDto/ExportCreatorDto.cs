﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Boardgames.Data.Models;

namespace Boardgames.DataProcessor.ExportDto
{
    [XmlType("Creator")]
    public class ExportCreatorDto
    {
        [XmlElement("CreatorName")]
        public string CreatorName { get; set; }
        [XmlAttribute("BoardgamesCount")]
        public int Count { get; set; }
        [XmlArray()]
        public ExportBoardgameDto[] Boardgames { get; set; }
    }
}