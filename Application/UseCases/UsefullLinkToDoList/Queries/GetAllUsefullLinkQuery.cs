using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Queries
{
    public class GetAllUsefullLinkQuery : IRequest<List<UsefullLink>>
    {
        public GetAllUsefullLinkQuery() { }
    }
}
