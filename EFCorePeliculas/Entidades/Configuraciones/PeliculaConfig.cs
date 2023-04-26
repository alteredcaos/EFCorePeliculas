using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace EFCorePeliculas.Entidades.Configuraciones
{
	public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
	{
		public void Configure(EntityTypeBuilder<Pelicula> builder)
		{
			builder.Property(prop => prop.Titulo)
				.HasMaxLength(150)
				.IsRequired();
			
			builder.Property(prop => prop.PosterURL)
			.HasMaxLength(150)
			.IsUnicode(false);
		}
	}
}
