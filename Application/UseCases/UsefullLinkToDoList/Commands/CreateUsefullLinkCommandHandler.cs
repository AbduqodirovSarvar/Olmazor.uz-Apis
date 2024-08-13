using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Commands
{
    public class CreateUsefullLinkCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IFileService fileService
        ) : IRequestHandler<CreateUsefullLinkCommand, UsefullLink>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly IFileService _fileService = fileService;

        public async Task<UsefullLink> Handle(CreateUsefullLinkCommand request, CancellationToken cancellationToken)
        {
            var usefullLink = _mapper.Map<UsefullLink>(request);
            usefullLink.Photo = await _fileService.SaveFileAsync(request.Photo) ?? throw new Exception("Could not save this photo");
            await _appDbContext.UsefulLinks.AddAsync(usefullLink, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return usefullLink;
        }
    }
}
