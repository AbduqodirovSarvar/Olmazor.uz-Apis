using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Commands
{
    public class UpdateJobFairCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateJobFairCommand, JobFair>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async  Task<JobFair> Handle(UpdateJobFairCommand request, CancellationToken cancellationToken)
        {
            var jobFair = await _appDbContext.JobFairs.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                      ?? throw new Exception("Job Fair not found");

            jobFair.NameEn = request.NameEn ?? jobFair.NameEn;
            jobFair.NameRu = request.NameRu ?? jobFair.NameRu;
            jobFair.NameUz = request.NameUz ?? jobFair.NameUz;
            jobFair.NameUzRu = request.NameUzRu ?? jobFair.NameUz;
            jobFair.DescriptionEn = request.DescriptionEn ?? jobFair.DescriptionEn;
            jobFair.DescriptionRu = request.DescriptionRu ?? jobFair.DescriptionRu;
            jobFair.DescriptionUzRu = request.DescriptionUzRu ?? jobFair.DescriptionUzRu;
            jobFair.DescriptionUz = request.DescriptionUz ?? jobFair.DescriptionUz;

            jobFair.Email = request.Email ?? jobFair.Email;
            jobFair.Phone = request.Phone ?? jobFair.Phone;
            jobFair.ReceptionDays = request.ReceptionDays ?? jobFair.ReceptionDays;
            jobFair.ReceptionTime = request.ReceptionTime ?? jobFair.ReceptionTime;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return jobFair;
        }
    }
}
