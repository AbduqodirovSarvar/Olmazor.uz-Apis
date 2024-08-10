using Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeViewModel>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
