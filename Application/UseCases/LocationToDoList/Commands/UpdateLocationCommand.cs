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
    public class UpdateLocationCommand : IRequest<Location>
    {
        [Required]
        public Guid Id { get; set; }
        public string? NameUz { get; set; } = null;
        public string? NameEn { get; set; } = null;
        public string? NameRu { get; set; } = null;
        public string? NameUzRu { get; set; } = null;
        public string? NameKaa {  get; set; } = null;
        public double? Latitude { get; set; } = null;
        public double? Longitude { get; set; } = null;
    }
}
