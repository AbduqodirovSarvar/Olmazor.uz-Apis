using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Queries
{
    public class GetUsefullLinkQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetUsefullLinkQuery, UsefulLink>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<UsefulLink> Handle(GetUsefullLinkQuery request, CancellationToken cancellationToken)
        {
            var usefulLink = await _appDbContext.UsefulLinks.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                            ?? throw new Exception("Usefull link not found");
            return usefulLink;
        }
    }
}
