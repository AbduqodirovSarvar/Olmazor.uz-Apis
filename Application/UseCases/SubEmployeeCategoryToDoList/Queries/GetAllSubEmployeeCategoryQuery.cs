using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SubEmployeeCategoryToDoList.Queries
{
    public class GetAllSubEmployeeCategoryQuery : IRequest<List<SubEmployeeCategory>>
    {
        public GetAllSubEmployeeCategoryQuery() { }
    }
}
