using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Commands
{
    public class CreateLocationCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateLocationCommand, Location>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<Location> Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            var location = _mapper.Map<Location>(request);

            await _appDbContext.Locations.AddAsync(location, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return location;
        }
    }
}
