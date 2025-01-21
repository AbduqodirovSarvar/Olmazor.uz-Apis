using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.ViewModels.Abstractions;
using Domain.Entities;

namespace Application.Models.ViewModels
{
    public class PostViewModel : FullLocalizableViewModel
    {
        public EnumViewModel? Category { get; set; }
        public string? Photo { get; set; }
        public ICollection<Image>? Images { get; set; }
    }
}
