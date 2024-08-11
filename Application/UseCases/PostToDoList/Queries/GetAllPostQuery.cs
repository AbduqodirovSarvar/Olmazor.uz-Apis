using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Queries
{
    public class GetAllPostQuery : IRequest<List<Post>>
    {
        public GetAllPostQuery() { }
    }
}
