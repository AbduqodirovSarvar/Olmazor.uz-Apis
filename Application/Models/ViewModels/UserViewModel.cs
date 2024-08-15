using Application.Models.ViewModels.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class UserViewModel : AbstractViewModel
    {
        public string? FirstnameEn { get; set; }
        public string? FirstnameRu { get; set; }
        public string? LastnameEn { get; set; }
        public string? LastnameRu { get; set; }

        public EnumViewModel? Gender { get; set; }
        public EnumViewModel? Userrole { get; set; }

        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
        public string? Email { get; set; }
        public string? Photo { get; set; }
    }
}
