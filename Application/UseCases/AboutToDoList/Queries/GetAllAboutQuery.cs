using Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AboutToDoList.Queries
{
    public class GetAllAboutQuery : IRequest<List<AboutViewModel>>
    {
        public GetAllAboutQuery() { }
    }
}
