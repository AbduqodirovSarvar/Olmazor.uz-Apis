using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Queries
{
    public class GetContactByIdQuery : IRequest<Contact>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
