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
    public class GetJobFairQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetJobFairQuery, JobFair>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<JobFair> Handle(GetJobFairQuery request, CancellationToken cancellationToken)
        {
            var jobfair = await _appDbContext.JobFairs.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                      ?? throw new Exception("Job Fair not found");

            return jobfair;
        }
    }
}
