using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Commands
{
    public class UpdateUsefullLinkCommandHandler(
        IAppDbContext appDbContext,
        IFileService fileService
        ) : IRequestHandler<UpdateUsefullLinkCommand, UsefullLink>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IFileService _fileService = fileService;

        public async Task<UsefullLink> Handle(UpdateUsefullLinkCommand request, CancellationToken cancellationToken)
        {
            var usefullLink = await _appDbContext.UsefulLinks.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                             ?? throw new Exception("Usefull link not found");

            usefullLink.NameEn = request.NameEn ?? usefullLink.NameEn;
            usefullLink.NameUz = request.NameUz ?? usefullLink.NameUz;
            usefullLink.NameRu = request.NameRu ?? usefullLink.NameRu;
            usefullLink.NameUzRu = request.NameUzRu ?? usefullLink.NameUzRu;
            usefullLink.Link = request.Link ?? usefullLink.Link;
            usefullLink.Photo = request.Photo != null ? (await _fileService.SaveFileAsync(request.Photo) ?? throw new Exception("Could not save this photo"))
                                                      : usefullLink.Photo;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return usefullLink;
        }
    }
}
