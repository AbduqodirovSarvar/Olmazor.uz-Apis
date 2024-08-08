using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string? FirstnameEn { get; set; }
        public string? FirstnameRu { get; set; }
        public string? LastnameEn { get; set; }
        public string? LastnameRu { get; set; }
        public Gender Gender { get; set; }
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Email { get; set; }
        public string? Photo { get; set; }
        public UserRole Userrole { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
