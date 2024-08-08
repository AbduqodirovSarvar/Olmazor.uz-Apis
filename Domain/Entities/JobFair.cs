using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobFair : FullLocalizableEntity
    {
        [Phone]
        public string Phone { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public ICollection<WeekDays> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;
    }
}
