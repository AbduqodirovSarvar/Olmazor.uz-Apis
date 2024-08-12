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
            var slidesTask = _appDbContext.Slides.ToListAsync(cancellationToken);
            var contactsTask = _appDbContext.Contacts.ToListAsync(cancellationToken);
            var aboutTask = _appDbContext.Abouts.Include(x => x.Location)
                                         .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync(cancellationToken);
            var employeesTask = _appDbContext.EmployeesCategories
                                         .Include(x => x.SubEmployeeCategories).ThenInclude(x => x.Employees)
                                         .ToListAsync(cancellationToken);
            var jobfairsTask = _appDbContext.JobFairs.ToListAsync(cancellationToken);
            var postsTask = _appDbContext.PostCategories
                                         .Include(x => x.Posts)
                                         .ToListAsync(cancellationToken);
            var sectorsTask = _appDbContext.Sectors
                                         .Include(x => x.Location)
                                         .Include(x => x.Employee)
                                         .ToListAsync(cancellationToken);
            var tasksOrFunctionsTask = _appDbContext.TasksAndFunctions.ToListAsync(cancellationToken);
            var usefullLinksTask = _appDbContext.UsefulLinks.ToListAsync(cancellationToken);

            await Task.WhenAll(
                slidesTask, 
                contactsTask,
                aboutTask,
                employeesTask,
                jobfairsTask,
                postsTask,
                sectorsTask,
                tasksOrFunctionsTask,
                usefullLinksTask
                );

            return new CommonViewModel()
            {
                Slides = slidesTask.Result,
                Contacts = contactsTask.Result,
                About = aboutTask.Result,
                EmployeeCategories = employeesTask.Result,
                JobFairs = jobfairsTask.Result,
                PostCategories = postsTask.Result,
                Sectors = sectorsTask.Result,
                TasksAndFunctions = tasksOrFunctionsTask.Result,
                UsefulLinks = usefullLinksTask.Result
            };

        }
    }
}
