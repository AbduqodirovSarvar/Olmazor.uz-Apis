using Application.Abstractions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDoList.Commands
{
    public class DeleteUserCommandHandler(
        IAppDbContext appDbContext,
        ICurrentUserService currentUserService
        ) : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == _currentUserService.Id, cancellationToken)
                                                 ?? throw new Exception("Current User not found");

            if(!(currentUser.Userrole == Domain.Enums.UserRole.Admin || currentUser.Userrole == Domain.Enums.UserRole.SuperAdmin) || request.Id != currentUser.Id)
            {
                throw new Exception("Access denied");
            }

            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                          ?? throw new Exception("User not found");

            _appDbContext.Users.Remove(user);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
