using System;
using ElitTournamentWeb.Entities.Entities.Interfaces;

namespace ElitTournamentWeb.Entities.Entities
{
	public class BaseEntity : IBaseEntity
	{
		public string Id { get; set; }
		public DateTime CreationDate { get; set; }
		
		public BaseEntity()
		{
			Id = Guid.NewGuid().ToString();
			CreationDate = DateTime.UtcNow;
		}
	}
}