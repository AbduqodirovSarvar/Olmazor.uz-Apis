using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class CommonViewModel
    {
        public List<EmployeeCategoryViewModel> EmployeeCategories { get; set; } = [];
        public List<PostCategoryViewModel>? PostCategories { get; set; }
        public List<SectorViewModel>? Sectors { get; set; }
        public List<ContactViewModel> Contacts { get; set; } = [];
        public AboutViewModel? About { get; set; }
        public List<JobFairViewModel> JobFairs { get; set; } = [];
        public List<SlideViewModel>? Slides { get; set; }
        public List<TaskOrFunctionsViewModel>? TasksAndFunctions { get; set;}
        public List<UsefullLinkViewModel>? UsefulLinks { get; set; }
    }
}
