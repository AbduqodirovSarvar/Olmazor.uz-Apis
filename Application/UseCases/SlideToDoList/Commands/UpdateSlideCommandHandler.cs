using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SlideToDoList.Commands
{
    public class UpdateSlideCommandHandler(
        IAppDbContext appDbContext,
        IFileService fileService
        ) : IRequestHandler<UpdateSlideCommand, Slide>
    {
        private readonly IFileService _fileService = fileService;
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Slide> Handle(UpdateSlideCommand request, CancellationToken cancellationToken)
        {
            var slide = await _appDbContext.Slides.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                  ?? throw new Exception("Slide not found");

            slide.NameEn = request.NameEn ?? slide.NameEn;
            slide.NameRu = request.NameRu ?? slide.NameRu;
            slide.NameUz = request.NameUz ?? slide.NameUz;
            slide.NameUzRu = request.NameUzRu ?? slide.NameUzRu;
            slide.NameKaa = request.NameKaa ?? slide.NameKaa;
            slide.DescriptionEn = request.DescriptionEn ?? slide.DescriptionEn;
            slide.DescriptionRu = request.DescriptionRu ?? slide.DescriptionRu;
            slide.DescriptionUz = request.DescriptionUz ?? slide.DescriptionUz;
            slide.DescriptionUzRu = request.DescriptionUzRu ?? slide.DescriptionUzRu;
            slide.DescriptionKaa = request.DescriptionKaa ?? slide.DescriptionKaa;
            slide.Photo = request.Photo != null ? (await _fileService.SaveFileAsync(request.Photo) ?? throw new Exception("Could not save this photo")) 
                                                : slide.Photo;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return slide;
        }
    }
}
