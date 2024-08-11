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
    public class GetSectorQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetSectorQuery, Sector>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Sector> Handle(GetSectorQuery request, CancellationToken cancellationToken)
        {
            var sector = await _appDbContext.Sectors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                        ?? throw new Exception("Sector not found");
            return sector;
        }
    }
}
