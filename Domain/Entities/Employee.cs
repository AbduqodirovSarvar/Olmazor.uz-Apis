using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : PersonBaseEntity
    {
        public Guid SubEmployeeCategoryId { get; set; }
        public SubEmployeeCategory? SubEmployeeCategory { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateOnly WorkFromDate { get; set; }
        public string WorkPlace { get; set; } = string.Empty;
        public ICollection<WeekDays> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;
    }
}
