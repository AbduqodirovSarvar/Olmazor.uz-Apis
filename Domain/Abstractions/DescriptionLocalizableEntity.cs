using Domain.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class DescriptionLocalizableEntity : AudiTableEntity, IDescriptionLocalizableEntity
    {
        public string? DescriptionUz { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionRu { get; set; }
        public string? DescriptionUzRu { get; set; }
        public string? DescriptionKaa { get; set; }
    }
}
