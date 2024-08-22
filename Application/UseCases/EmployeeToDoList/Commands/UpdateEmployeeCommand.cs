using Application.Models.ViewModels;
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
    public class UpdateEmployeeCommand : IRequest<EmployeeViewModel>
    {
        [Required]
        public Guid Id { get; set; }
        public string? FirstnameEn { get; set; } = null;
        public string? FirstnameRu { get; set; } = null;
        public string? LastnameEn { get; set; } = null;
        public string? LastnameRu { get; set; } = null;
        public Gender? Gender { get; set; } = null;

        [Phone]
        public string? Phone1 { get; set; } = null;
        [Phone]
        public string? Phone2 { get; set; } = null;

        [EmailAddress]
        public string? Email { get; set; } = null;

        public IFormFile? Photo { get; set; } = null;
        public EmployeeCategory? Category { get; set; } = null;

        public string? NationalityEn { get; set; } = null;
        public string? NationalityUz { get; set; } = null;
        public string? NationalityRu { get; set; } = null;
        public string? NationalityUzRu { get; set; } = null;
        public string? NationalityKaa { get; set; } = null;

        public DateOnly? Birthday { get; set; } = null;

        public string? BirthPlaceUz { get; set; } = null;
        public string? BirthPlaceEn { get; set; } = null;
        public string? BirthPlaceRu { get; set; } = null;
        public string? BirthPlaceUzRu { get; set; } = null;
        public string? BirthPlaceKaa { get; set; } = null;


        public string? PositionEn { get; set; } = null;
        public string? PositionUz { get; set; } = null;
        public string? PositionRu { get; set; } = null;
        public string? PositionUzRu { get; set; } = null;
        public string? PositionKaa { get; set; } = null;

        public DateOnly? WorkFromDate { get; set; } = null;

        public string? WorkPlaceUz { get; set; } = null;
        public string? WorkPlaceEn { get; set; } = null;
        public string? WorkPlaceRu { get; set; } = null;
        public string? WorkPlaceUzRu { get; set; } = null;
        public string? WorkPlaceKaa { get; set; } = null;

        public string? ReceptionTimeUz { get; set; } = null;
        public string? ReceptionTimeEn { get; set; } = null         ;
        public string? ReceptionTimeRu { get; set; } = null ;
        public string? ReceptionTimeUzRu { get; set; } = null;
        public string? ReceptionTimeKaa { get; set; } = null;
    }
}
