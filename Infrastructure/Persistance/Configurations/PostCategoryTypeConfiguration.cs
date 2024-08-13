using Domain.Entities;
using Infrastructure.Persistance.Configurations.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configurations
{
    public class PostCategoryTypeConfiguration : NameLocalizableConfiguration<PostCategory>
    {
        public override void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            base.Configure(builder);
        }
    }
}
