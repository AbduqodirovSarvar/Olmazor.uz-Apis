using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SlideToDoList.Commands
{
    public class CreateSlideCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IFileService fileService
        ) : IRequestHandler<CreateSlideCommand, Slide>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly IFileService _fileService = fileService;

        public async Task<Slide> Handle(CreateSlideCommand request, CancellationToken cancellationToken)
        {
            var slide = _mapper.Map<Slide>(request);
            slide.Photo = await _fileService.SaveFileAsync(request.Photo) ?? throw new Exception("Could not save this photo");

            await _appDbContext.Slides.AddAsync(slide, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return slide;
        }
    }
}
