using System.Collections.Generic;

namespace ElitTournamentWeb.ViewModels.Team
{
	public class GetTeamsAllResponse
	{
		public GetTeamsAllResponse(IEnumerable<TeamItem> teams)
		{
			Teams = teams;
		}
		
		public IEnumerable<TeamItem> Teams { get; set; }
	}
	
}