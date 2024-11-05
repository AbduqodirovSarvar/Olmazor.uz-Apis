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
            var slides = await _appDbContext.Slides
                                          .OrderByDescending(x => x.CreatedAt)
                                          .ToListAsync(cancellationToken);
            var contacts = await _appDbContext.Contacts
                                        .OrderByDescending(x => x.CreatedAt)
                                        .ToListAsync(cancellationToken);
            var about = await _appDbContext.Abouts
                                         .Include(x => x.Location)
                                         .OrderByDescending(x => x.CreatedAt).FirstOrDefaultAsync(cancellationToken);
            var sectors = await _appDbContext.Sectors
                                         .Include(x => x.Location)
                                         .Include(x => x.Employee)
                                         .OrderByDescending(x => x.CreatedAt)
                                         .ToListAsync(cancellationToken);
            var usefullLinks = await _appDbContext.UsefulLinks
                                        .OrderByDescending(x => x.CreatedAt)
                                        .ToListAsync(cancellationToken);
            var posts = await _appDbContext.Posts
                                        .OrderByDescending(x => x.CreatedAt)
                                        .ToListAsync(cancellationToken);
            var employees = await _appDbContext.Employees
                                        .OrderBy(x => x.CreatedAt)
                                        .ToListAsync(cancellationToken);

            return new CommonViewModel()
            {
                Slides = _mapper.Map<List<SlideViewModel>>(slides),
                Contacts = _mapper.Map<List<ContactViewModel>>(contacts),
                About = _mapper.Map<AboutViewModel>(about),
                Sectors = _mapper.Map<List<SectorViewModel>>(sectors),
                UsefulLinks = _mapper.Map<List<UsefullLinkViewModel>>(usefullLinks),
                Posts = _mapper.Map<List<PostViewModel>>(posts),
                Employees = _mapper.Map<List<EmployeeViewModel>>(employees)                
            };
        }
    }
}
