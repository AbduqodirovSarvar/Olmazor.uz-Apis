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
        public List<EmployeeCategory>? EmployeeCategories { get; set; }
        public List<PostCategory>? PostCategories { get; set; }
        public List<Sector>? Sectors { get; set; }
        public List<Contact>? Contacts { get; set; }
        public About? About { get; set; }
        public List<JobFair>? JobFairs { get; set; }
        public List<Slide>? Slides { get; set; }
        public List<TaskOrFunction>? TasksAndFunctions { get; set;}
        public List<UsefullLink>? UsefulLinks { get; set; }
    }
}
