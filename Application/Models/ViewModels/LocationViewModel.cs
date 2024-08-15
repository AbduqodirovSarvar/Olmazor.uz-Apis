using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models.ViewModels.Abstractions;

namespace Application.Models.ViewModels
{
    public class LocationViewModel : NameLocalizableViewModel
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
