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
    public class GetAllLocationQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllLocationQuery, List<Location>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<Location>> Handle(GetAllLocationQuery request, CancellationToken cancellationToken)
        {
            var locations = await _appDbContext.Locations.ToListAsync(cancellationToken);
            return locations;
        }
    }
}
