using Application.Models.ViewModels.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class EmployeeCategoryViewModel : NameLocalizableViewModel
    {
        public List<SubEmployeeCategoryViewModel> SubEmployeeCategories { get; set; } = [];
    }
}
