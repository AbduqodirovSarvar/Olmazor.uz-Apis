using Domain.Abstractions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class NameLocalizableEntity : AudiTableEntity, INameLocalizableEntity
    {
        public string? NameUz { get; set; }
        public string? NameEn { get; set; }
        public string? NameRu { get; set; }
        public string? NameUzRu { get; set; }
        public string? NameKaa { get; set; }
    }
}
