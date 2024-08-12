using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Commands
{
    public class DeleteUsefullLinkCommand : IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
