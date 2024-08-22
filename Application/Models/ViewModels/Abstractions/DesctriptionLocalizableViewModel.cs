using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels.Abstractions
{
    public abstract class DesctriptionLocalizableViewModel : AbstractViewModel
    {
        public string? DescriptionUz { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionRu { get; set; }
        public string? DescriptionUzRu { get; set; }
        public string? DescriptionKaa { get; set; }
    }
}
