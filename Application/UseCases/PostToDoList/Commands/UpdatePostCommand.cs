﻿using Domain.Entities;
using Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.PostToDoList.Commands
{
    public class UpdatePostCommand : IRequest<Post>
    {
        [Required]
        public Guid Id { get; set; }

        public string? NameUz { get; set; } = null;
        public string? NameEn { get; set; } = null;
        public string? NameRu { get; set; } = null;
        public string? NameUzRu { get; set; } = null;
        public string? NameKaa { get; set; } = null;

        public string? DescriptionUz { get; set; } = null;
        public string? DescriptionEn { get; set; } = null;
        public string? DescriptionRu { get; set; } = null;
        public string? DescriptionUzRu { get; set; } = null;
        public string? DescriptionKaa { get; set; } = null;

        public PostCategory? Category { get; set; } = null;
        public IFormFile? Photo { get; set; } = null;
        public ICollection<string> DeletingImages { get; set; } = [];
        public ICollection<IFormFile> Images { get; set; } = [];
    }
}
