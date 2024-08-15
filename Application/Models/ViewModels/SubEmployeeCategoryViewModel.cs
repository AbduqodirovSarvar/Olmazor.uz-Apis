using Application.Models.ViewModels.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class SubEmployeeCategoryViewModel : NameLocalizableViewModel
    {
        public Guid EmployeeCategoryId { get; set; }
        public List<EmployeeViewModel> Employees { get; set; } = [];
    }
}
