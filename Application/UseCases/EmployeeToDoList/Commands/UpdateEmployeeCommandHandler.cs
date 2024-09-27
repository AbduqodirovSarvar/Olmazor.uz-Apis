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

            employee.FirstnameEn = request?.FirstnameEn ?? employee.FirstnameEn;
            employee.FirstnameRu = request?.FirstnameRu ?? employee.FirstnameRu;
            employee.LastnameEn = request?.LastnameEn ?? employee.LastnameEn;
            employee.LastnameRu = request?.LastnameRu ?? employee.LastnameRu;
            employee.NationalityEn = request?.NationalityEn ?? employee.NationalityEn;
            employee.NationalityUz = request?.NationalityUz ?? employee.NationalityUz;
            employee.NationalityRu = request?.NationalityRu ?? employee.NationalityRu;
            employee.NationalityUzRu = request?.NationalityUzRu ?? employee.NationalityUzRu;
            employee.Email = request?.Email ?? employee.Email;
            employee.Phone1 = request?.Phone1 ?? employee.Phone1;
            employee.Phone2 = request?.Phone2 ?? employee.Phone2;

            employee.BirthPlaceUz = request?.BirthPlaceUz ?? employee.BirthPlaceUz;
            employee.BirthPlaceRu = request?.BirthPlaceRu ?? employee.BirthPlaceRu;
            employee.BirthPlaceEn = request?.BirthPlaceEn ?? employee.BirthPlaceEn;
            employee.BirthPlaceUzRu = request?.BirthPlaceUzRu ?? employee.BirthPlaceUzRu;
            employee.BirthPlaceKaa = request?.BirthPlaceKaa ?? employee.BirthPlaceKaa;

            employee.Birthday = request?.Birthday ?? employee.Birthday;

            employee.PositionEn = request?.PositionEn ?? employee.PositionEn;
            employee.PositionRu = request?.PositionRu ?? employee.PositionRu;
            employee.PositionUz = request?.PositionUz ?? employee.PositionUz;
            employee.PositionUzRu = request?.PositionUzRu ?? employee.PositionUzRu;
            employee.PositionKaa = request?.PositionKaa ?? employee.PositionKaa;

            employee.Gender = request?.Gender ?? employee.Gender;

            employee.Category = request?.Category ?? employee.Category;

            employee.WorkFromDate = request?.WorkFromDate ?? employee.WorkFromDate;

            employee.WorkPlaceRu = request?.WorkPlaceRu ?? employee.WorkPlaceRu;
            employee.WorkPlaceUz = request?.WorkPlaceUz ?? employee.WorkPlaceUz;
            employee.WorkPlaceUzRu = request?.WorkPlaceUzRu ?? employee.WorkPlaceUzRu;
            employee.WorkPlaceEn = request?.WorkPlaceEn ?? employee.WorkPlaceEn;
            employee.WorkPlaceKaa = request?.WorkPlaceKaa ?? employee.WorkPlaceKaa;

            employee.ReceptionTimeEn = request?.ReceptionTimeEn ?? employee.ReceptionTimeEn;
            employee.ReceptionTimeRu = request?.ReceptionTimeRu ?? employee.ReceptionTimeRu;
            employee.ReceptionTimeUz = request?.ReceptionTimeUz ?? employee.ReceptionTimeUz;
            employee.ReceptionTimeUzRu = request?.ReceptionTimeUzRu ?? employee.ReceptionTimeUzRu;
            employee.ReceptionTimeKaa = request?.ReceptionTimeKaa ?? employee.ReceptionTimeKaa;

            if (request?.Photo != null)
            {
                employee.Photo = await _fileService.SaveFileAsync(request.Photo);
            }

            await _appDbContext.SaveChangesAsync(cancellationToken);

            return _mapper.Map<EmployeeViewModel>(employee);
        }
    }
}
