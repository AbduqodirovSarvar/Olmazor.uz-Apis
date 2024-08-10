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
        public Guid SubEmployeeCategoryId { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateOnly WorkFromDate { get; set; }
        public string WorkPlace { get; set; } = string.Empty;
        public ICollection<WeekDays> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;
    }
}
