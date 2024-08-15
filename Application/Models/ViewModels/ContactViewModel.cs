﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.ViewModels.Abstractions;

namespace Application.Models.ViewModels
{
    public class ContactViewModel : NameLocalizableViewModel
    {
        public string? Value { get; set; }
    }
}
