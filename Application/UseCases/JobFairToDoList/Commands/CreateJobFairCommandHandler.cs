using Application.Abstractions;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Commands
{
    public class CreateJobFairCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<CreateJobFairCommand, JobFair>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<JobFair> Handle(CreateJobFairCommand request, CancellationToken cancellationToken)
        {
            var jobFair = _mapper.Map<JobFair>(request);

            await _appDbContext.JobFairs.AddAsync(jobFair, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return jobFair;
        }
    }
}
