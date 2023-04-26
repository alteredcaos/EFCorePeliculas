namespace EFCorePeliculas.Entidades
{
	public class SaladeCine
	{
		public int Id { get; set; }
		public decimal Precio { get; set; }
		public int CineId { get; set; }

		public Cine Cine { get; set; }

		public HashSet<Pelicula> Peliculas { get; set; }
		public TiposSalaDeCine TiposSalaDeCine { get; set; }

	}
}
