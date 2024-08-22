using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee : PersonBaseEntity
    {
        public EmployeeCategory Category { get; set; }
        public string? NationalityEn { get; set; }
        public string? NationalityUz { get; set; }
        public string? NationalityRu { get; set; }
        public string? NationalityUzRu { get; set; }
        public string? NationalityKaa { get; set; }

        public DateOnly Birthday { get; set; }

        public string? BirthPlaceUz { get; set; }
        public string? BirthPlaceEn { get; set; }
        public string? BirthPlaceRu { get; set; }
        public string? BirthPlaceUzRu { get; set; }
        public string? BirthPlaceKaa { get; set; }

        public string? PositionEn { get; set; }
        public string? PositionUz { get; set; }
        public string? PositionRu { get; set; }
        public string? PositionUzRu { get; set; }
        public string? PositionKaa { get; set; }

        public DateOnly WorkFromDate { get; set; }

        public string? WorkPlaceUz { get; set; }
        public string? WorkPlaceEn { get; set; }
        public string? WorkPlaceRu { get; set; }
        public string? WorkPlaceUzRu { get; set; }
        public string? WorkPlaceKaa { get; set; }

        public string? ReceptionTimeUz { get; set; }
        public string? ReceptionTimeEn { get; set; }
        public string? ReceptionTimeRu { get; set; }
        public string? ReceptionTimeUzRu { get; set; }
        public string? ReceptionTimeKaa { get; set; }
    }
}
