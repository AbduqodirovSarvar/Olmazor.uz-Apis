using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AboutToDoList.Commands
{
    public class CreateAboutCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateAboutCommand, AboutViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<AboutViewModel> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
        {
            var about = _mapper.Map<About>(request);

            await _appDbContext.Abouts.AddAsync(about, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<AboutViewModel>(about);
        }
    }
}
