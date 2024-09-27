using Application.Abstractions;
using Application.Services;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Commands
{
    public class UpdateSectorCommandHandler(
        IAppDbContext appDbContext,
        IFileService fileService
        ) : IRequestHandler<UpdateSectorCommand, Sector>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IFileService _fileService = fileService;

        public async Task<Sector> Handle(UpdateSectorCommand request, CancellationToken cancellationToken)
        {
            var sector = await _appDbContext.Sectors.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                    ?? throw new Exception("Sector not found");

            sector.NameEn = request?.NameEn ?? sector.NameEn;
            sector.NameRu = request?.NameRu ?? sector.NameRu;
            sector.NameUz = request?.NameUz ?? sector.NameUz;
            sector.NameUzRu = request?.NameUzRu ?? sector.NameUzRu;
            sector.DescriptionEn = request?.DescriptionEn ?? sector.DescriptionEn;
            sector.DescriptionRu = request?.DescriptionRu ?? sector.DescriptionRu;
            sector.DescriptionUz = request?.DescriptionUz ?? sector.DescriptionUz;
            sector.DescriptionUzRu = request?.DescriptionUzRu ?? sector.DescriptionUzRu;
            sector.EmployeeId = request?.EmployeeId ?? sector.EmployeeId;
            sector.LocationId = request?.LocationId ?? sector.LocationId;
            if(request?.Photo != null)
            {
                sector.Photo = await _fileService.SaveFileAsync(request.Photo);
            }

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return sector;
        }
    }
}
