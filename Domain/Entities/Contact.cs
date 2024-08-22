using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contact : AudiTableEntity
    {
        public ContactType Type { get; set; }
        public string? Value { get; set; }
    }
}
