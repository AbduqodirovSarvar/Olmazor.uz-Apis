using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class About : DescriptionLocalizableEntity
    {
        public Guid LocationId { get; set; }
        public Location? Location { get; set; }
        public ICollection<WeekDays> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;
    }
}
