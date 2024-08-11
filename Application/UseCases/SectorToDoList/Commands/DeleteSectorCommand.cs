using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Commands
{
    public class DeleteSectorCommand : IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
