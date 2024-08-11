using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Commands
{
    public class CreateSectorCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateSectorCommand, Sector>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<Sector> Handle(CreateSectorCommand request, CancellationToken cancellationToken)
        {
            var sector = _mapper.Map<Sector>(request);
            await _appDbContext.Sectors.AddAsync(sector, cancellationToken);
            return sector;
        }
    }
}
