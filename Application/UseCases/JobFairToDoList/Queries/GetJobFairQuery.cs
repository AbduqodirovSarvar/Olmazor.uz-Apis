using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Queries
{
    public class GetJobFairQuery : IRequest<JobFair>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
