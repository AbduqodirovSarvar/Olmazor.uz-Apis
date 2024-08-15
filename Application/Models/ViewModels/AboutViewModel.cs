﻿using Application.Models.ViewModels.Abstractions;
using Domain.Abstractions;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class AboutViewModel : DescriptionLocalizableEntity
    {
        public Guid LocationId { get; set; }
        public LocationViewModel? Location { get; set; }
        public List<EnumViewModel>? ReceptionDays { get; set; }
    }
}
