using Application.Models.ViewModels.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class SectorViewModel : FullLocalizableViewModel
    {
        public Guid EmployeeId { get; set; }
        public EmployeeViewModel? Employee { get; set; }
        public Guid LocationId { get; set; }
        public LocationViewModel? Location { get; set; }
    }
}
