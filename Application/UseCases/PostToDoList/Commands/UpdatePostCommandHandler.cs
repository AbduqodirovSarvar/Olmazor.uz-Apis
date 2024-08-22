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
            var post = await _appDbContext.Posts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                ?? throw new Exception("Post not found");

            post.NameRu = request.NameRu ?? post.NameRu;
            post.NameEn = request.NameEn ?? post.NameEn;
            post.NameUz = request.NameUz ?? post.NameUz;
            post.NameUzRu = request.NameUzRu ?? post.NameUzRu;
            post.NameKaa = request.NameKaa ?? post.NameKaa;

            post.DescriptionEn = request.DescriptionEn ?? post.DescriptionEn;
            post.DescriptionRu = request.DescriptionRu ?? post.DescriptionRu;
            post.DescriptionUz = request.DescriptionUz ?? post.DescriptionUz;
            post.DescriptionUzRu = request.DescriptionUzRu ?? post.DescriptionUzRu;
            post.DescriptionKaa = request.DescriptionKaa ?? post.DescriptionKaa;

            post.Category = request.Category ?? post.Category;
            post.Photo = await _fileService.SaveFileAsync(request.Photo);

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return post;
        }
    }
}
