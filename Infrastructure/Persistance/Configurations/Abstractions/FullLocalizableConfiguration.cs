using Domain.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configurations.Abstractions
{
    public class FullLocalizableConfiguration<TEntity> : AudiTableEntityConfiguration<TEntity> where TEntity : FullLocalizableEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => new { x.NameEn, x.NameUz, x.NameRu, x.NameUzRu }).IsUnique();
        }
    }
}
