using Domain.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configurations.Abstractions
{
    public class PersonBaseEntityConfiguration<TEntity> : AudiTableEntityConfiguration<TEntity> where TEntity : PersonBaseEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => new { x.Phone1, x.Phone2 }).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
