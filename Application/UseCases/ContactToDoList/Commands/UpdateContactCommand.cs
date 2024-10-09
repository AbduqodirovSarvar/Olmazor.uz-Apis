using Application.Models.ViewModels;
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
    public class UpdateContactCommand : IRequest<ContactViewModel>
    {
        [Required]
        public Guid Id { get; set; }
        public ContactType? Type { get; set; } = null;
        public string? Value { get; set; } = null;
    }
}
