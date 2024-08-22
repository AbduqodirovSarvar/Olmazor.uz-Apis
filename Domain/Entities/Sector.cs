using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sector : FullLocalizableEntity
    {
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public Guid LocationId { get; set; }
        public Location? Location { get; set; }
        public string? Photo { get; set; }
    }
}
