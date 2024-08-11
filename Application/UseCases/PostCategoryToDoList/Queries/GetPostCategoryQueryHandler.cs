using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostCategoryToDoList.Queries
{
    public class GetPostCategoryQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetPostCategoryQuery, PostCategory>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<PostCategory> Handle(GetPostCategoryQuery request, CancellationToken cancellationToken)
        {
            var postCategory = await _appDbContext.PostCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                 ?? throw new Exception("Post Category not found");

            return postCategory;
        }
    }
}
