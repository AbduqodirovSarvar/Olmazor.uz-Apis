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
        public Guid PostCategoryId { get; set; }
        public PostCategoryViewModel? PostCategory { get; set; }
        public string? Photo { get; set; }
    }
}
