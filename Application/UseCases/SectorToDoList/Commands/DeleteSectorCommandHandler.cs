using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Commands
{
    public class DeleteSectorCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteSectorCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteSectorCommand request, CancellationToken cancellationToken)
        {
            var sector = await _appDbContext.Sectors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                    ?? throw new Exception("Sector not found");

            _appDbContext.Sectors.Remove(sector);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
