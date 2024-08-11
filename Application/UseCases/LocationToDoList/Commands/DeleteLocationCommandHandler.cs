using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Commands
{
    public class DeleteLocationCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteLocationCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteLocationCommand request, CancellationToken cancellationToken)
        {
            var location = await _appDbContext.Locations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Location not found");

            _appDbContext.Locations.Remove(location);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
