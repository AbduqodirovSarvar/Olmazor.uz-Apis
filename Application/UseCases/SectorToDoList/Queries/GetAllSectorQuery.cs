using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Queries
{
    public class GetAllSectorQuery : IRequest<List<Sector>>
    {
        public GetAllSectorQuery() { }
    }
}
