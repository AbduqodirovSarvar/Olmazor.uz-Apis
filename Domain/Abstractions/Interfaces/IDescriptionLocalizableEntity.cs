using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions.Interfaces
{
    public interface IDescriptionLocalizableEntity
    {
        string? DescriptionUz { get; set; }
        string? DescriptionEn { get; set; }
        string? DescriptionRu { get; set; }
        string? DescriptionUzRu { get; set; }
        string? DescriptionKaa { get; set; }
    }
}
