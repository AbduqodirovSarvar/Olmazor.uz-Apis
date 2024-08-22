using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Commands
{
    public class CreateContactCommand : IRequest<Contact>
    {
        [Required]
        public ContactType Type { get; set; }
        public string? Value { get; set; }
    }
}
