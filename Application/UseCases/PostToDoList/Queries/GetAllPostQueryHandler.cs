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
    public class GetAllPostQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllPostQuery, List<Post>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<Post>> Handle(GetAllPostQuery request, CancellationToken cancellationToken)
        {
            var posts = new List<Post>();
            if (request?.Type != null)
            {
                posts = await _appDbContext.Posts.Include(x => x.Images).OrderByDescending(x => x.CreatedAt).Where(x => x.Category == request.Type).ToListAsync(cancellationToken);
            }
            else
            {
                posts = await _appDbContext.Posts.Include(x => x.Images).OrderByDescending(x => x.CreatedAt).ToListAsync(cancellationToken);
            }
            return posts;
        }
    }
}
