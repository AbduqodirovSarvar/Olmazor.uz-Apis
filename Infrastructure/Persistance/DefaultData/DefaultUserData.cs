using Application.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.DefaultData
{
    public static class DefaultUserData
    {
        public static User DefaultUser { get; private set; } = null!;

        public static void Initialize(IHashService hashService)
        {
            DefaultUser = new User()
            {
                FirstnameEn = "Super Admin",
                FirstnameRu = "Суперадминистратор",
                LastnameEn = "Olmazor",
                LastnameRu = "Олмазор",
                Phone1 = "+998932340316",
                Phone2 = "+998332340316",
                Email = "info@olmazor.uz",
                PasswordHash = hashService.GetHash("Olmazor123!@#"),
                Userrole = Domain.Enums.UserRole.SuperAdmin
            };
        }
    }
}
