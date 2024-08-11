using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Queries
{
    public class GetLocationQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetLocationQuery, Location>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Location> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            var location = await _appDbContext.Locations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Location not found");

            return location;
        }
    }
}
