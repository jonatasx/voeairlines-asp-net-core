using ApiVoeAirlines.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Voeairlines.EntityConfigurations
{

    public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>

    {
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("Aeronaves");
            builder.HasKey(a=>a.Id);
            builder.Property(a=>a.Fabricante)
                    .IsRequired()
                    .HasMaxLength(60);

        }
    }

}