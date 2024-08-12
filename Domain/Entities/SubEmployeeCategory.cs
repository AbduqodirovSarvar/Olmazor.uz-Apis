using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SubEmployeeCategory : NameLocalizableEntity
    {
        public Guid EmployeeCategoryId { get; set; }
        public EmployeeCategory? EmployeeCategory { get; set; }
        public ICollection<Employee> Employees { get; set; } = [];
    }
}
