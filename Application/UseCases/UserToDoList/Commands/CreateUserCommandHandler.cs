using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDoList.Commands
{
    public class CreateUserCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IHashService hashService,
        IFileService fileService
        ) : IRequestHandler<CreateUserCommand, UserViewModel>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IHashService _hashService = hashService;
        private readonly IFileService _fileService = fileService;

        public async Task<UserViewModel> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(request);
            user.PasswordHash = _hashService.GetHash(request.Password);
            user.Photo = await _fileService.SaveFileAsync(request.Photo);

            await _appDbContext.Users.AddAsync(user, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);
            return _mapper.Map<UserViewModel>(user);
        }
    }
}
