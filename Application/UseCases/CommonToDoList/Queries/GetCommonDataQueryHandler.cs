using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using Domain.Entities;
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
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetCommonDataQuery, CommonViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<CommonViewModel> Handle(GetCommonDataQuery request, CancellationToken cancellationToken)
        {
            var slides = await _appDbContext.Slides.ToListAsync(cancellationToken);
            var contacts = await _appDbContext.Contacts.ToListAsync(cancellationToken);
            var about = await _appDbContext.Abouts.Include(x => x.Location)
                                         .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync(cancellationToken);
            var employees = await _appDbContext.EmployeesCategories
                                         .Include(x => x.SubEmployeeCategories).ThenInclude(x => x.Employees)
                                         .ToListAsync(cancellationToken);
            var jobfairs =await _appDbContext.JobFairs.ToListAsync(cancellationToken);
            var posts = await _appDbContext.PostCategories
                                         .Include(x => x.Posts)
                                         .ToListAsync(cancellationToken);
            var sectors = await _appDbContext.Sectors
                                         .Include(x => x.Location)
                                         .Include(x => x.Employee)
                                         .ToListAsync(cancellationToken);
            var tasksOrFunctions = await _appDbContext.TasksAndFunctions.ToListAsync(cancellationToken);
            var usefullLinks = await _appDbContext.UsefulLinks.ToListAsync(cancellationToken);

            return new CommonViewModel()
            {
                Slides = _mapper.Map<List<SlideViewModel>>(slides),
                Contacts = _mapper.Map<List<ContactViewModel>>(contacts),
                About = _mapper.Map<AboutViewModel>(about),
                EmployeeCategories = _mapper.Map<List<EmployeeCategoryViewModel>>(employees),
                JobFairs = _mapper.Map<List<JobFairViewModel>>(jobfairs),
                PostCategories = _mapper.Map<List<PostCategoryViewModel>>(posts),
                Sectors = _mapper.Map<List<SectorViewModel>>(sectors),
                TasksAndFunctions = _mapper.Map<List<TaskOrFunctionsViewModel>>(tasksOrFunctions),
                UsefulLinks = _mapper.Map<List<UsefullLinkViewModel>>(usefullLinks)
            };

        }
    }
}
