using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels.Abstractions
{
    public abstract class DesctriptionLocalizableViewModel : AbstractViewModel
    {
        public string DescriptionUz { get; set; } = string.Empty;
        public string DescriptionEn { get; set; } = string.Empty;
        public string DescriptionRu { get; set; } = string.Empty;
        public string DescriptionUzRu { get; set; } = string.Empty;
    }
}
