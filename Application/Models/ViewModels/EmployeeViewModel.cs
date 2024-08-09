﻿using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class EmployeeViewModel
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

        public Guid SubEmployeeCategoryId { get; set; }
        public SubEmployeeCategory? SubEmployeeCategory { get; set; }
        public string Nationality { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public string BirthPlace { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateOnly WorkFromDate { get; set; }
        public string WorkPlace { get; set; } = string.Empty;
        public ICollection<EnumViewModel> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;

        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}