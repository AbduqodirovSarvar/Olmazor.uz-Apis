using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class EnumViewModel
    {
        public int Id { get; set; }
        public string NameUz { get; set; } = string.Empty;
        public string NameEn { get; set; } = string.Empty;
        public string NameRu { get; set; } = string.Empty;
        public string NameUzRu { get; set; } = string.Empty;
        public string NameKaa { get; set; } = string.Empty;
    }
}
