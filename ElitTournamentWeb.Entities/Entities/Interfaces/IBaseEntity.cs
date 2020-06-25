using System;

namespace ElitTournamentWeb.Entities.Entities.Interfaces
{
	public interface IBaseEntity
	{
		int Id { get; set; }

		DateTime CreationDate { get; set; }
	}
}