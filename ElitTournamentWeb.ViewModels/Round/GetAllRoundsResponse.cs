using System.Collections.Generic;

namespace ElitTournamentWeb.ViewModels.Round
{
	public class GetAllRoundsResponse
	{
		public GetAllRoundsResponse(IEnumerable<RoundItem> rounds)
		{
			Rounds = rounds;
		}
		
		public IEnumerable<RoundItem> Rounds { get; set; }
	}
}