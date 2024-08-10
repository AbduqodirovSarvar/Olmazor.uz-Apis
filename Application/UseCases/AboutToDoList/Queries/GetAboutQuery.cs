using Application.Models.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AboutToDoList.Queries
{
    public class GetAboutQuery : IRequest<AboutViewModel>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
