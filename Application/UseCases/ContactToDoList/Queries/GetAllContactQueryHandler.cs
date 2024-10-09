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

namespace Application.UseCases.ContactToDoList.Queries
{
    public class GetAllContactQueryHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetAllContactQuery, List<ContactViewModel>>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;

        public async Task<List<ContactViewModel>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _appDbContext.Contacts.ToListAsync(cancellationToken);
            return _mapper.Map<List<ContactViewModel>>(contacts);
        }
    }
}
