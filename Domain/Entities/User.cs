using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : PersonBaseEntity
    {
        public UserRole Userrole { get; set; }
        public string PasswordHash { get; set; } = null!;
    }
}
