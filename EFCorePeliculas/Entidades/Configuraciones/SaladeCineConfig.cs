using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
	public class SaladeCineConfig : IEntityTypeConfiguration<SaladeCine>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<SaladeCine> builder)
		{
			builder.Property(prop => prop.Precio)
				.HasPrecision(precision: 9, scale: 2);

			builder.Property(prop => prop.TiposSalaDeCine)
			.HasDefaultValue(TiposSalaDeCine.DosDimensiones);
		}
	}
}
