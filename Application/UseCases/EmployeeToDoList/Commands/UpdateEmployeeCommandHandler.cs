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

namespace Application.UseCases.EmployeeToDoList.Commands
{
    public class UpdateEmployeeCommandHandler(
        IAppDbContext appDbContext,
        IFileService fileService,
        IMapper mapper
        ) : IRequestHandler<UpdateEmployeeCommand, EmployeeViewModel>
    {
        private readonly IAppDbContext _appDbContext = appDbContext;
        private readonly IFileService _fileService = fileService;
        private readonly IMapper _mapper = mapper;

        public async Task<EmployeeViewModel> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _appDbContext.Employees.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken)
                                                        ?? throw new Exception("Employee not found");

            employee.FirstnameEn = request.FirstnameEn ?? employee.FirstnameEn;
            employee.FirstnameRu = request.FirstnameRu ?? employee.FirstnameRu;
            employee.LastnameEn = request.LastnameEn ?? employee.LastnameEn;
            employee.LastnameRu = request.LastnameRu ?? employee.LastnameRu;
            employee.Nationality = request.Nationality ?? employee.Nationality;
            employee.Email = request.Email ?? employee.Email;
            employee.Phone1 = request.Phone1 ?? employee.Phone1;
            employee.Phone2 = request.Phone2 ?? employee.Phone2;

            employee.BirthPlace = request.BirthPlace ?? employee.BirthPlace;
            employee.Birthday = request.Birthday ?? employee.Birthday;
            employee.PositionEn = request.PositionEn ?? employee.PositionEn;
            employee.PositionRu = request.PositionRu ?? employee.PositionRu;
            employee.PositionUz = request.PositionUz ?? employee.PositionUz;
            employee.PositionUzRu = request.PositionUzRu ?? employee.PositionUzRu;
            employee.Gender = request.Gender ?? employee.Gender;

            employee.WorkPlace = request.WorkPlace ?? employee.WorkPlace;
            employee.WorkFromDate = request.WorkFromDate ?? employee.WorkFromDate;
            employee.ReceptionDays = request.ReceptionDays ?? employee.ReceptionDays;
            employee.ReceptionTime = request.ReceptionTime ?? employee.ReceptionTime;
            employee.SubEmployeeCategoryId = request.SubEmployeeCategoryId ?? employee.SubEmployeeCategoryId;

            if (request.Photo != null)
            {
                employee.Photo = await _fileService.SaveFileAsync(request.Photo);
            }

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<EmployeeViewModel>(employee);
        }
    }
}
