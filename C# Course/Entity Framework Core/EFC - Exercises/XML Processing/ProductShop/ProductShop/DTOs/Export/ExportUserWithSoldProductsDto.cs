﻿using System;
using System.Xml.Serialization;

namespace ProductShop.DTOs.Export
{
    [XmlType("User")]
    public class ExportUserWithSoldProductsDto
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; } = null!;

        [XmlElement("lastName")]
        public string LastName { get; set; } = null!;

        [XmlElement("age")]
        public int Age { get; set; }

        [XmlElement("SoldProducts")]
        public ExportSoldProductsCountAndProducts SoldProducts { get; set; } = null!;
    }
}

