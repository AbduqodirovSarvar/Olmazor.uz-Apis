using Application.Models.ViewModels;
using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.EmployeeToDoList.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeViewModel>
    {
        [Required]
        public string FirstnameEn { get; set; } = null!;
        [Required]
        public string FirstnameRu { get; set; } = null!;
        [Required]
        public string LastnameEn { get; set; } = null!;
        [Required]
        public string LastnameRu { get; set; } = null!;

        public Gender Gender { get; set; }

        [Phone]
        public string Phone1 { get; set; } = string.Empty;
        [Phone]
        public string Phone2 { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public IFormFile? Photo { get; set; }
        public EmployeeCategory Category { get; set; }

        public string NationalityEn { get; set; } = string.Empty;
        public string NationalityUz { get; set; } = string.Empty;
        public string NationalityRu { get; set; } = string.Empty;
        public string NationalityUzRu { get; set; } = string.Empty;
        public string NationalityKaa { get; set; } = string.Empty;

        public DateOnly Birthday { get; set; }
        public string BirthPlaceUz { get; set; } = string.Empty;
        public string BirthPlaceEn { get; set; } = string.Empty;
        public string BirthPlaceRu { get; set; } = string.Empty;
        public string BirthPlaceUzRu { get; set; } = string.Empty;
        public string BirthPlaceKaa { get; set; } = string.Empty;

        public string PositionEn { get; set; } = string.Empty;
        public string PositionUz { get; set; } = string.Empty;
        public string PositionRu { get; set; } = string.Empty;
        public string PositionUzRu { get; set; } = string.Empty;
        public string PositionKaa { get; set; } = string.Empty;

        public DateOnly WorkFromDate { get; set; }
        public string WorkPlaceUz { get; set; } = string.Empty;
        public string WorkPlaceEn { get; set; } = string.Empty;
        public string WorkPlaceRu { get; set; } = string.Empty;
        public string WorkPlaceUzRu { get; set; } = string.Empty;
        public string WorkPlaceKaa { get; set; } = string.Empty;

        public string ReceptionTimeUz { get; set; } = string.Empty;
        public string ReceptionTimeEn { get; set; } = string.Empty;
        public string ReceptionTimeRu { get; set; } = string.Empty;
        public string ReceptionTimeUzRu { get; set; } = string.Empty;
        public string ReceptionTimeKaa { get; set; } = string.Empty;
    }
}
