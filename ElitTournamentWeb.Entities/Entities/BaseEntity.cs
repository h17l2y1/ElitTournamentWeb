using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ElitTournamentWeb.Entities.Entities.Interfaces;

namespace ElitTournamentWeb.Entities.Entities
{
	public class BaseEntity : IBaseEntity
	{
		public BaseEntity()
		{
			CreationDate = DateTime.UtcNow;
		}

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		public DateTime CreationDate { get; set; }
	}
}