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
    public class GetAllUsefullLinkQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllUsefullLinkQuery, List<UsefulLink>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<UsefulLink>> Handle(GetAllUsefullLinkQuery request, CancellationToken cancellationToken)
        {
            var usefullLinks = await _appDbContext.UsefulLinks.ToListAsync(cancellationToken);
            return usefullLinks;
        }
    }
}
