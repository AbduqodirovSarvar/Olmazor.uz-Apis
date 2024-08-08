﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions.Interfaces
{
    public interface INameLocalizableEntity
    {
        string NameUz { get; set; }
        string NameEn { get; set; }
        string NameRu { get; set; }
        string NameUzRu { get; set; }
    }
}
