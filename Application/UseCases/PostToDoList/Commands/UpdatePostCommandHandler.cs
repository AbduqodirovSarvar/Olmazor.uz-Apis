using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Commands
{
    public class UpdatePostCommandHandler(
        IAppDbContext appDbContext,
        IFileService fileService
        ) : IRequestHandler<UpdatePostCommand, Post>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IFileService _fileService = fileService;

        public async Task<Post> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _appDbContext.Posts.Include(x =>x .Images).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                ?? throw new Exception("Post not found");

            post.NameRu = request?.NameRu ?? post.NameRu;
            post.NameEn = request?.NameEn ?? post.NameEn;
            post.NameUz = request?.NameUz ?? post.NameUz;
            post.NameUzRu = request?.NameUzRu ?? post.NameUzRu;
            post.NameKaa = request?.NameKaa ?? post.NameKaa;

            post.DescriptionEn = request?.DescriptionEn ?? post.DescriptionEn;
            post.DescriptionRu = request?.DescriptionRu ?? post.DescriptionRu;
            post.DescriptionUz = request?.DescriptionUz ?? post.DescriptionUz;
            post.DescriptionUzRu = request?.DescriptionUzRu ?? post.DescriptionUzRu;
            post.DescriptionKaa = request?.DescriptionKaa ?? post.DescriptionKaa;

            post.Category = request?.Category ?? post.Category;
            if(request?.Photo != null)
            {
                post.Photo = await _fileService.SaveFileAsync(request.Photo);
            }

            if(request != null && request.DeletingImages.Count > 0)
            {
                post.Images = post.Images.Where(x => !request.DeletingImages.Contains(x.Name)).ToList();
            }

            if(request != null && request.Images.Count > 0)
            {
                var imageTasks = request.Images.Select(async item =>
                {
                    var imgName = await _fileService.SaveFileAsync(item);
                    return new Domain.Entities.Image
                    {
                        Name = imgName ?? string.Empty,
                        ImageUrl = $"https://api.olmazor.uz/api/File/{imgName}",
                        PostId = post.Id
                    };
                });
                var images = (await Task.WhenAll(imageTasks)).ToList();

                post.Images.ToList().AddRange(images);
                _appDbContext.Images.AddRange(images);
            }
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return post;
        }
    }
}
