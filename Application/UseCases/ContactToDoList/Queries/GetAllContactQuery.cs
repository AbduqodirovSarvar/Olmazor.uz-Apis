using Application.Models.ViewModels;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Queries
{
    public class GetAllContactQuery : IRequest<List<ContactViewModel>>
    {
        public GetAllContactQuery() { }
    }
}
