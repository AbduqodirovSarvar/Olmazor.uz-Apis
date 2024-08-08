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
        public ICollection<EmployeeCategory> Categories { get; set; } = [];
        public ICollection<PostCategory> PostCategories { get; set; } = [];
        public ICollection<Sector> Sectors { get; set; } = [];
        public ICollection<Contact> Contacts { get; set; } = [];
        public About? About { get; set; }
        public ICollection<JobFair> JobFairs { get; set; } = [];
        public ICollection<Slide> Slides { get; set; } = [];
        public ICollection<TasksAndFunctions> TasksAndFunctions { get; set;} = [];
        public ICollection<UsefulLink> UsefulLinks { get; set; } = [];
    }
}
