using Application.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.EntityFramework
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeCategory> EmployeesCategories { get; set; }
        public DbSet<SubEmployeeCategory> SubEmployeeCategories { get; set; }
        public DbSet<JobFair> JobFairs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<TasksAndFunctions> TasksAndFunctions { get; set; }
        public DbSet<UsefulLink> UsefulLinks { get; set; }
    }
}
