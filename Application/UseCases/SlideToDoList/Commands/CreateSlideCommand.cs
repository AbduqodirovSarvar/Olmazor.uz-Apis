﻿using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.SlideToDoList.Commands
{
    public class CreateSlideCommand : IRequest<Slide>
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
        public string DescriptionUz { get; set; } = null!;
        [Required]
        public string DescriptionEn { get; set; } = null!;
        [Required]
        public string DescriptionRu { get; set; } = null!;
        [Required]
        public string DescriptionUzRu { get; set; } = null!;
        [Required]
        public IFormFile Photo { get; set; } = null!;
    }
}