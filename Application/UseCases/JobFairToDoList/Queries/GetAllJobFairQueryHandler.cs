using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Queries
{
    public class GetAllJobFairQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllJobFairQuery, List<JobFair>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<JobFair>> Handle(GetAllJobFairQuery request, CancellationToken cancellationToken)
        {
            var jobFairs = await _appDbContext.JobFairs.ToListAsync(cancellationToken);
            return jobFairs;
        }
    }
}
