using Application.Abstractions;
using Application.Models.ViewModels;
using Application.Services;
using AutoMapper;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDoList.Commands
{
    public class UpdateUserCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IHashService hashService,
        IFileService fileService,
        ICurrentUserService currentUserService
        ) : IRequestHandler<UpdateUserCommand, UserViewModel>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IHashService _hashService = hashService;
        private readonly IFileService _fileService = fileService;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        public async Task<UserViewModel> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var currentUser = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == _currentUserService.Id, cancellationToken)
                                                 ?? throw new Exception("Current User not found");

            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                          ?? throw new Exception("User not found");

            if ((currentUser.Userrole == UserRole.SuperAdmin || currentUser.Userrole == UserRole.Admin) && currentUser.Id != user.Id && request?.Password != null)
            {
                user.PasswordHash = _hashService.GetHash(request.Password);
            }

            if (currentUser.Id == user.Id && !(currentUser.Userrole == UserRole.SuperAdmin || currentUser.Userrole == UserRole.Admin) && request?.Password != null)
            {
                if (request.OldPassword == null)
                {
                    throw new Exception("Old Password needs to not null");
                }

                if (!_hashService.VerifyHash(request.OldPassword, user.PasswordHash))
                {
                    throw new Exception("Old password incorrect");
                }
                user.PasswordHash = _hashService.GetHash(request.Password);
            }

            if(request?.Userrole != null && (request?.Userrole == UserRole.SuperAdmin || request?.Userrole == UserRole.Admin) && currentUser.Userrole != UserRole.SuperAdmin)
            {
                throw new Exception("Access denied");
            }

            if (request?.Photo != null)
            {
                var photoFileName = await _fileService.SaveFileAsync(request.Photo)
                                                      ?? throw new Exception("Cannot save the photo");

                user.Photo = photoFileName;
            }

            user.FirstnameEn = request?.FirstnameEn ?? user.FirstnameEn;
            user.LastnameEn = request?.LastnameEn ?? user.LastnameEn;
            user.FirstnameRu = request?.FirstnameRu ?? user.FirstnameRu;
            user.LastnameRu = request?.LastnameRu ?? user.LastnameRu;
            user.Email = request?.Email ?? user.Email;
            user.Phone1 = request?.Phone1 ?? user.Phone1;
            user.Phone2 = request?.Phone2 ?? user.Phone2;
            user.Gender = request?.Gender ?? user.Gender;
            user.Userrole = request?.Userrole ?? user.Userrole;

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<UserViewModel>(user);
        }
    }
}
