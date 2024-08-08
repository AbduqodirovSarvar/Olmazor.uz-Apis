using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class PersonBaseEntity : AudiTableEntity
    {
        public string FirstnameEn { get; set; } = null!;
        public string FirstnameRu { get; set; } = null!;
        public string LastnameEn { get; set; } = null!;
        public string LastnameRu { get; set; } = null!;

        public Gender Gender { get; set; }

        [Phone]
        public string Phone1 { get; set; } = string.Empty;
        [Phone]
        public string Phone2 { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string? Photo { get; set; }
    }
}
