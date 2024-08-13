using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Queries
{
    public class GetUsefullLinkQuery : IRequest<UsefullLink>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
