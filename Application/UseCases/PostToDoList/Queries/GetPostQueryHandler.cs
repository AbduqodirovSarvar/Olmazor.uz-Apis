using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Queries
{
    public class GetPostQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetPostQuery, Post>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Post> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var post = await _appDbContext.Posts.Include(x => x.Images).FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                ?? throw new Exception("Post not found");
            return post;
        }
    }
}
