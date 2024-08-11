﻿using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Commands
{
    public class DeleteContactCommand : IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }
    }
}