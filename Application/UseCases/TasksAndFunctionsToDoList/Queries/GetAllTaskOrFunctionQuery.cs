using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.TasksAndFunctionsToDoList.Queries
{
    public class GetAllTaskOrFunctionQuery : IRequest<List<TaskOrFunction>>
    {
        public GetAllTaskOrFunctionQuery() { }
    }
}
