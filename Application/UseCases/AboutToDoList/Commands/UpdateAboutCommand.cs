using Application.Models.ViewModels;
using Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AboutToDoList.Commands
{
    public class UpdateAboutCommand : IRequest<AboutViewModel>
    {
        [Required]
        public Guid Id { get; set; }
        public string? DescriptionUz { get; set; } = null;
        public string? DescriptionEn { get; set; } = null;
        public string? DescriptionRu { get; set; } = null;
        public string? DescriptionUzRu { get; set; } = null;
        public Guid? LocationId { get; set; } = null;
        public List<WeekDays>? ReceptionDays { get; set; } = null;
        public string? ReceptionTime { get; set; } = null;
    }
}
