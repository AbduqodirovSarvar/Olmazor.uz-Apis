using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CommonToDoList.Queries
{
    public class GetCommonDataQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetCommonDataQuery, CommonViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<CommonViewModel> Handle(GetCommonDataQuery request, CancellationToken cancellationToken)
        {
            var slidesTask = await _appDbContext.Slides.ToListAsync(cancellationToken);
            var contactsTask = await _appDbContext.Contacts.ToListAsync(cancellationToken);
            var aboutTask = await _appDbContext.Abouts.Include(x => x.Location)
                                         .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync(cancellationToken);
            var employeesTask = await _appDbContext.EmployeesCategories
                                         .Include(x => x.SubEmployeeCategories).ThenInclude(x => x.Employees)
                                         .ToListAsync(cancellationToken);
            var jobfairsTask =await _appDbContext.JobFairs.ToListAsync(cancellationToken);
            var postsTask = await _appDbContext.PostCategories
                                         .Include(x => x.Posts)
                                         .ToListAsync(cancellationToken);
            var sectorsTask = await _appDbContext.Sectors
                                         .Include(x => x.Location)
                                         .Include(x => x.Employee)
                                         .ToListAsync(cancellationToken);
            var tasksOrFunctionsTask = await _appDbContext.TasksAndFunctions.ToListAsync(cancellationToken);
            var usefullLinksTask = await _appDbContext.UsefulLinks.ToListAsync(cancellationToken);

             /*Task.WhenAll(
                slidesTask, 
                contactsTask,
                aboutTask,
                employeesTask,
                jobfairsTask,
                postsTask,
                sectorsTask,
                tasksOrFunctionsTask,
                usefullLinksTask
                );*/

            return new CommonViewModel()
            {
                Slides = slidesTask,
                Contacts = contactsTask,
                About = aboutTask,
                EmployeeCategories = employeesTask,
                JobFairs = jobfairsTask,
                PostCategories = postsTask,
                Sectors = sectorsTask,
                TasksAndFunctions = tasksOrFunctionsTask,
                UsefulLinks = usefullLinksTask
            };

        }
    }
}
