using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeCategoryToDoList.Queries
{
    public class GetAllEmployeeCategoryQuery : IRequest<List<EmployeeCategory>>
    {
        public GetAllEmployeeCategoryQuery() { }
    }
}
