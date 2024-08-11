using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Queries
{
    public class GetAllLocationQuery : IRequest<List<Location>>
    {
        public GetAllLocationQuery() { }
    }
}
