using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UsefullLinkToDoList.Commands
{
    public class CreateUsefullLinkCommand : IRequest<UsefullLink>
    {
        [Required]
        public string NameUz { get; set; } = null!;
        [Required]
        public string NameEn { get; set; } = null!;
        [Required]
        public string NameRu { get; set; } = null!;
        [Required]
        public string NameUzRu { get; set; } = null!;
        public string NameKaa { get; set; } = string.Empty;
        [Required]
        public string Link { get; set; } = null!;
        [Required]
        public IFormFile Photo { get; set; } = null!;
    }
}
