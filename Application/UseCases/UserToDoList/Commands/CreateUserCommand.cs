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

namespace Application.UseCases.UserToDoList.Commands
{
    public class CreateUserCommand : IRequest<UserViewModel>
    {
        [Required]
        public string FirstnameEn { get; set; } = null!;
        [Required]
        public string FirstnameRu { get; set; } = null!;
        [Required]
        public string LastnameEn { get; set; } = null!;
        [Required]
        public string LastnameRu { get; set; } = null!;

        [Required]
        public Gender Gender { get; set; }
        [Required]
        public UserRole Userrole { get; set; }

        [Phone]
        public string Phone1 { get; set; } = string.Empty;
        [Phone]
        public string Phone2 { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = null!;

        public IFormFile? Photo { get; set; }
    }
}
