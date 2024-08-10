using Application.Abstractions;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Commands
{
    public class DeleteJobFairCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<DeleteJobFairCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<bool> Handle(DeleteJobFairCommand request, CancellationToken cancellationToken)
        {
            var jobFair = await _appDbContext.JobFairs.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                      ?? throw new Exception("Job Fair not found");

            _appDbContext.JobFairs.Remove(jobFair);

            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
