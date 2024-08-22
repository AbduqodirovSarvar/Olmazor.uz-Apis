using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels.Abstractions
{
    public abstract class FullLocalizableViewModel : AbstractViewModel
    {
        public string? NameUz { get; set; }
        public string? NameEn { get; set; }
        public string? NameRu { get; set; }
        public string? NameUzRu { get; set; }
        public string? NameKaa { get; set; }

        public string? DescriptionUz { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionRu { get; set; }
        public string? DescriptionUzRu { get; set; }
        public string? DescriptionKaa { get; set; }
    }
}
