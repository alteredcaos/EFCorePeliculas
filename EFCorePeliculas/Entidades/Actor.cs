﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EFCorePeliculas.Entidades
{
	public class Actor
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Biografia { get; set; }
		//[Column(TypeName = "Date")]
		public DateTime? Fechanacimiento { get; set; }

		public HashSet<PeliculaActor> PeliculaActores { get; set; }

	}
}
