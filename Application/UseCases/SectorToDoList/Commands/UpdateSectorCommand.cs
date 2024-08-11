using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SectorToDoList.Commands
{
    public class UpdateSectorCommand : IRequest<Sector>
    {
        [Required]
        public Guid Id { get; set; }

        public string? NameUz { get; set; } = null;
        public string? NameEn { get; set; } = null;
        public string? NameRu { get; set; } = null;
        public string? NameUzRu { get; set; } = null;
        public string? DescriptionUz { get; set; } = null;
        public string? DescriptionEn { get; set; } = null;
        public string? DescriptionRu { get; set; } = null;
        public string? DescriptionUzRu { get; set; } = null;
        public Guid? EmployeeId { get; set; } = null;
        public Guid? LocationId { get; set; } = null;
    }
}
