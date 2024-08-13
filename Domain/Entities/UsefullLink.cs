using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UsefullLink : NameLocalizableEntity
    {
        public string Link { get; set; } = null!;
        public string Photo { get; set; } = null!;
    }
}
