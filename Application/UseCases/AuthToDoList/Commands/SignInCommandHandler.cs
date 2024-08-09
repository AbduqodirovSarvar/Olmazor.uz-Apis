﻿using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AuthToDoList.Commands
{
    public class SignInCommandHandler(
        IAppDbContext appDbContext,
        ITokenService tokenService,
        IHashService hashService,
        IMapper mapper
        ) : IRequestHandler<SignInCommand, LoginViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly ITokenService _tokenService = tokenService;
        private readonly IHashService _hashService = hashService;
        private readonly IMapper _mapper = mapper;

        public async Task<LoginViewModel> Handle(SignInCommand request, CancellationToken cancellationToken)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken)
                                          ?? throw new Exception("User not found");

            if (!_hashService.VerifyHash(request.Password, user.PasswordHash))
            {
                throw new Exception("Login or password incorrect!");
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString()),
            };

            if (user.Userrole == UserRole.SuperAdmin)
            {
                foreach (var role in Enum.GetValues(typeof(UserRole)).Cast<UserRole>())
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.ToString()));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, user.Userrole.ToString()));
            }

            return new LoginViewModel()
            {
                User = _mapper.Map<UserViewModel>(user),
                AccessToken = _tokenService.GetAccessToken([.. claims])
            };
        }
    }
}
