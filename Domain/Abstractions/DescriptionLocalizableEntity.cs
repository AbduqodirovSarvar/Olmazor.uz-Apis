﻿using Domain.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class DescriptionLocalizableEntity : AudiTableEntity, IDescriptionLocalizableEntity
    {
        public string DescriptionUz { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        public string DescriptionRu { get; set; } = string.Empty;
        public string DescriptionUzRu { get; set; } = string.Empty;
    }
}
