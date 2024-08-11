using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostCategoryToDoList.Commands
{
    public class DeletePostCategoryCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeletePostCategoryCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeletePostCategoryCommand request, CancellationToken cancellationToken)
        {
            var postCategory = await _appDbContext.PostCategories.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                                 ?? throw new Exception("Post Category not found");

            _appDbContext.PostCategories.Remove(postCategory);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
