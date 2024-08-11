using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Commands
{
    public class DeletePostCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeletePostCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = await _appDbContext.Posts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                ?? throw new Exception("Post not found");

            _appDbContext.Posts.Remove(post);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
