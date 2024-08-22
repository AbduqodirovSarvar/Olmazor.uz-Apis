using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IAppDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<About> Abouts { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Location> Locations { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Sector> Sectors { get; set; }
        DbSet<Slide> Slides { get; set; }
        DbSet<UsefullLink> UsefulLinks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
