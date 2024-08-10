using Application.Abstractions;
using Application.Models.ViewModels;
using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Commands
{
    public class CreateEmployeeCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        IFileService fileService
        ) : IRequestHandler<CreateEmployeeCommand, EmployeeViewModel>
    {
        private readonly IMapper _mapper = mapper;
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IFileService _fileService = fileService;

        public async Task<EmployeeViewModel> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = _mapper.Map<Employee>(request);
            employee.Photo = await _fileService.SaveFileAsync(request.Photo);

            await _appDbContext.Employees.AddAsync(employee, cancellationToken);
            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<EmployeeViewModel>(request);
        }
    }
}
