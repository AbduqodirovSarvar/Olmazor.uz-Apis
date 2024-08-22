using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Commands
{
    public class UpdateLocationCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateLocationCommand, Location>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Location> Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var location = await _appDbContext.Locations.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Location not found");

            location.NameEn = request.NameEn ?? location.NameEn;
            location.NameRu = request.NameRu ?? location.NameRu;
            location.NameUz = request.NameUz ?? location.NameUz;
            location.NameUzRu = request.NameUzRu ?? location.NameUzRu;
            location.NameKaa = request.NameKaa ?? location.NameKaa;

            location.Latitude = request.Latitude ?? location.Latitude;
            location.Longitude = request.Longitude ?? location.Longitude;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return location;
        }
    }
}
