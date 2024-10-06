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

            var deletingUser = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                 ?? throw new Exception("user not found");

            if ((deletingUser.Userrole == Domain.Enums.UserRole.Admin || deletingUser.Userrole == Domain.Enums.UserRole.SuperAdmin)
                && currentUser.Userrole != Domain.Enums.UserRole.SuperAdmin)
            {
                throw new Exception("Access denied: Only SuperAdmin can delete Admin or SuperAdmin users.");
            }
            else if (deletingUser.Userrole == Domain.Enums.UserRole.None
                && (currentUser.Userrole != Domain.Enums.UserRole.SuperAdmin && currentUser.Userrole != Domain.Enums.UserRole.Admin))
            {
                throw new Exception("Access denied: Only Admin or SuperAdmin can delete users with role 'None'.");
            }

            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                          ?? throw new Exception("User not found");

            _appDbContext.Users.Remove(user);
            return (await _appDbContext.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
