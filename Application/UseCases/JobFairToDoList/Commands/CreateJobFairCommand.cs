﻿using Domain.Entities;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.JobFairToDoList.Commands
{
    public class CreateJobFairCommand : IRequest<JobFair>
    {
        public string NameUz { get; set; } = null!;
        public string NameEn { get; set; } = null!;
        public string NameRu { get; set; } = null!;
        public string NameUzRu { get; set; } = null!;

        public string DescriptionUz { get; set; } = null!;
        public string DescriptionEn { get; set; } = null!;
        public string DescriptionRu { get; set; } = null!;
        public string DescriptionUzRu { get; set; } = null!;

        [Phone]
        public string Phone { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public List<WeekDays> ReceptionDays { get; set; } = [];
        public string ReceptionTime { get; set; } = string.Empty;
    }
}
