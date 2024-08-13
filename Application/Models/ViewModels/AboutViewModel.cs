using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class AboutViewModel
    {
        public Guid Id { get; set; }

        public Guid LocationId { get; set; }
        public Location? Location { get; set; }
        public List<EnumViewModel>? ReceptionDays { get; set; }
        public string? ReceptionTime { get; set; }
        public string? DescriptionUz { get; set; }
        public string? DescriptionEn { get; set; }
        public string? DescriptionRu { get; set; }
        public string? DescriptionUzRu { get; set; }

        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
