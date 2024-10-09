using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
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
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<UpdateContactCommand, ContactViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<ContactViewModel> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await _appDbContext.Contacts.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                          ?? throw new Exception("Contact not found");

            contact.Type = request?.Type ?? contact.Type;
            contact.Value = request?.Value ?? contact.Value;

            await _appDbContext.SaveChangesAsync(cancellationToken);
            return _mapper.Map<ContactViewModel>(contact);
        }
    }
}
