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
    public class UpdateUserCommand : IRequest<UserViewModel>
    {
        [Required]
        public Guid Id { get; set; }

        public string? FirstnameEn { get; set; }
        public string? FirstnameRu { get; set; }
        public string? LastnameEn { get; set; }
        public string? LastnameRu { get; set; }

        public Gender? Gender { get; set; }
        public UserRole? Userrole { get; set; }

        [Phone]
        public string? Phone1 { get; set; }
        [Phone]
        public string? Phone2 { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public IFormFile? Photo { get; set; }

        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public string? OldPassword { get; set; }
    }
}
