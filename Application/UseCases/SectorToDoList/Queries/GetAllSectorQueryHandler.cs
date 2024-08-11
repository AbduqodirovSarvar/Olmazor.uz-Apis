using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Queries
{
    public class GetAllSectorQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllSectorQuery, List<Sector>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<Sector>> Handle(GetAllSectorQuery request, CancellationToken cancellationToken)
        {
            var sectors = await _appDbContext.Sectors.ToListAsync(cancellationToken);
            return sectors;
        }
    }
}
