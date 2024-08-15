using Application.Models.ViewModels.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class SlideViewModel : FullLocalizableViewModel
    {
        public string? Photo { get; set; }
    }
}
