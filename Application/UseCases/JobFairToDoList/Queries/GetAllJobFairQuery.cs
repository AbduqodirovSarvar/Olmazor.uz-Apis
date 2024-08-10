using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Queries
{
    public class GetAllJobFairQuery : IRequest<List<JobFair>>
    {
        public GetAllJobFairQuery() { }
    }
}
