using Domain.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configurations.Abstractions
{
    public class DescriptionLocalizableConfirguration<TEntity> : AudiTableEntityConfiguration<TEntity> where TEntity : DescriptionLocalizableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}
