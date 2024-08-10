using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDoList.Queries
{
    public class GetCurrentUserQueryHandler(
        IAppDbContext appDbContext,
        ICurrentUserService currentUserService,
        IMapper mapper
        ) : IRequestHandler<GetCurrentUserQuery, UserViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<UserViewModel> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
        {
            var currentUser = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == _currentUserService.Id, cancellationToken)
                              ?? throw new Exception("User not found");

            return _mapper.Map<UserViewModel>(currentUser);
        }
    }
}
