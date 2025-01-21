using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Commands
{
    public class CreatePostCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IFileService fileService
        ) : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly IFileService _fileService = fileService;

        public async Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);
            post.Photo = await _fileService.SaveFileAsync(request.Photo);

            var imageTasks = request.Images.Select(async item =>
            {
                var imgName = await _fileService.SaveFileAsync(item);
                return new Image
                {
                    Name = imgName,
                    ImageUrl = $"https://api.olmazor.uz/api/File/{imgName}",
                    PostId = post.Id
                };
            });

            var images = (await Task.WhenAll(imageTasks)).ToList();

            post.Images = images;

            await _appDbContext.Posts.AddAsync(post, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return post;
        }
    }
}
