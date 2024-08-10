using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Queries
{
    public class GetAllContactQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetAllContactQuery, List<Contact>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<List<Contact>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _appDbContext.Contacts.ToListAsync(cancellationToken);
            return contacts;
        }
    }
}
