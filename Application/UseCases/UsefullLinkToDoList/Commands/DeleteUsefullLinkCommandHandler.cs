using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Commands
{
    public class DeleteUsefullLinkCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteUsefullLinkCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteUsefullLinkCommand request, CancellationToken cancellationToken)
        {
            var usefullLink = await _appDbContext.UsefulLinks.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                             ?? throw new Exception("Usefull link not found");
            _appDbContext.UsefulLinks.Remove(usefullLink);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
