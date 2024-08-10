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

namespace Application.UseCases.AboutToDoList.Queries
{
    public class GetAllAboutQueryHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetAllAboutQuery, List<AboutViewModel>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<List<AboutViewModel>> Handle(GetAllAboutQuery request, CancellationToken cancellationToken)
        {
            var abouts = await _appDbContext.Abouts.ToListAsync(cancellationToken);
            return _mapper.Map<List<AboutViewModel>>(abouts);
        }
    }
}
