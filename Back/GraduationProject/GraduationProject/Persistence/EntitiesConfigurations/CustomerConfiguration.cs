using GraduationProject.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GraduationProject.Persistence.EntitiesConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<customer>
    {
        public void Configure(EntityTypeBuilder<customer> builder)
        {
            // Configure the 'customer' entity

        }
    }
}
