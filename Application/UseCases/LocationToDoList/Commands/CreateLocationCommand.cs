using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.LocationToDoList.Commands
{
    public class CreateLocationCommand : IRequest<Location>
    {
        [Required]
        public string NameUz { get; set; } = null!;
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        public string NameRu { get; set; } = null!;
        [Required]
        public string NameUzRu { get; set; } = null!;
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
    }
}
