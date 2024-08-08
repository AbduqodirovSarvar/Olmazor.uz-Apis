using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contact : NameLocalizableEntity
    {
        public string? Value { get; set; }
    }
}
