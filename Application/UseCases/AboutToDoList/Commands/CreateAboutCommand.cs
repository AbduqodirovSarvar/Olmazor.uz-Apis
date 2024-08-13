using Application.Models.ViewModels;
using Domain.Entities;
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
    public class CreateAboutCommand : IRequest<AboutViewModel>
    {
        [Required]
        public string DescriptionUz { get; set; } = null!;
        [Required]
        public string DescriptionEn { get; set; } = null!;
        [Required]
        public string DescriptionRu { get; set; } = null!;
        [Required]
        public string DescriptionUzRu { get; set; } = null!;
        [Required]
        public Guid LocationId { get; set; }
        public List<WeekDays> ReceptionDays { get; set; } = [];
        public string? ReceptionTime { get; set; }
    }
}
