using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostCategoryToDoList.Commands
{
    public class UpdatePostCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdatePostCategoryCommand, PostCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<PostCategory> Handle(UpdatePostCategoryCommand request, CancellationToken cancellationToken)
        {
            var postCategory = await _appDbContext.PostCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                 ?? throw new Exception("Post catorgory not found");

            postCategory.NameEn = request.NameEn ?? postCategory.NameEn;
            postCategory.NameRu = request.NameRu ?? postCategory.NameRu;
            postCategory.NameUz = request.NameUz ?? postCategory.NameUz;
            postCategory.NameUzRu = request.NameUzRu ?? postCategory.NameUzRu;

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return postCategory;
        }
    }
}
