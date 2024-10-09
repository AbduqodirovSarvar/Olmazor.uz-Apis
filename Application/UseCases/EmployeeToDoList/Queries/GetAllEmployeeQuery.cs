using Application.Models.ViewModels;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<EmployeeViewModel>>
    {
        public GetAllEmployeeQuery() { }
        public EmployeeCategory? Type { get; set; } = null;
    }
}
