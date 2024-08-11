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
    public class GetAllPostCategoryQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllPostCategoryQuery, List<PostCategory>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<PostCategory>> Handle(GetAllPostCategoryQuery request, CancellationToken cancellationToken)
        {
            var postCategories = await _appDbContext.PostCategories.ToListAsync(cancellationToken);
            return postCategories;
        }
    }
}
