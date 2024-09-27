using Application.Abstractions;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.ContactToDoList.Commands
{
    public class UpdateContactCommandHandler(
        IAppDbContext appDbContext
        ) : IRequestHandler<UpdateContactCommand, Contact>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;

        public async Task<Contact> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _appDbContext.Contacts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                          ?? throw new Exception("Contact not found");

            contact.Type = request?.Type ?? contact.Type;
            contact.Value = request?.Value ?? contact.Value;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return contact;
        }
    }
}
