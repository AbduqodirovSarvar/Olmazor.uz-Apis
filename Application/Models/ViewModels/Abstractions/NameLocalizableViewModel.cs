using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels.Abstractions
{
    public abstract class NameLocalizableViewModel : AbstractViewModel
    {
        public string? NameUz { get; set; }
        public string? NameEn { get; set; }
        public string? NameRu { get; set; }
        public string? NameUzRu { get; set; }
        public string? NameKaa { get; set; }
    }
}
