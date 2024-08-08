using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post : FullLocalizableEntity
    {
        public Guid PostCategoryId { get; set; }
        public PostCategory? PostCategory { get; set; }
        public string? Photo { get; set; }
    }
}
