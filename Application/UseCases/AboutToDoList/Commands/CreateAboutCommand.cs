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
        public string DescriptionKaa { get; set; } = string.Empty;
        [Required]
        public Guid LocationId { get; set; }
        public string ReceptionTimeUz { get; set; } = string.Empty;
        public string ReceptionTimeEn { get; set; } = string.Empty;
        public string ReceptionTimeRu { get; set; } = string.Empty;
        public string ReceptionTimeUzRu { get; set; } = string.Empty;
        public string ReceptionTimeKaa { get; set; } = string.Empty;
    }
}
