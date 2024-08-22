using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Post : FullLocalizableEntity
    {
        public PostCategory Category { get; set; }
        public string? Photo { get; set; }
    }
}
