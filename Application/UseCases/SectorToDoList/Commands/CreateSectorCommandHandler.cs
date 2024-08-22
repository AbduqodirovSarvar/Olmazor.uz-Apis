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
        IMapper mapper,
        IFileService fileService 
        ) : IRequestHandler<CreateSectorCommand, Sector>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly IFileService _fileService = fileService;

        public async Task<Sector> Handle(CreateSectorCommand request, CancellationToken cancellationToken)
        {
            var sector = _mapper.Map<Sector>(request);
            sector.Photo = await _fileService.SaveFileAsync(request.Photo);
            await _appDbContext.Sectors.AddAsync(sector, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return sector;
        }
    }
}
