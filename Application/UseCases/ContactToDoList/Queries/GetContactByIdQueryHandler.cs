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
    public class GetContactByIdQueryHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<GetContactByIdQuery, Contact>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Contact> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
        {
            var contact = await _appDbContext.Contacts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                      ?? throw new Exception("Contact not found");
            return contact;
        }
    }
}
