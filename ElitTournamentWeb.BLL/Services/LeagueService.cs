using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.League;
using Newtonsoft.Json;

namespace ElitTournamentWeb.BLL.Services
{
	public class LeagueService : ILeagueService
	{
		private readonly IMapper _mapper;
		private readonly ILeagueRepository _leagueRepository;
		private readonly ITeamRepository _teamRepository;

		public LeagueService(IMapper mapper, ILeagueRepository leagueRepository, ITeamRepository teamRepository)
		{
			_mapper = mapper;
			_leagueRepository = leagueRepository;
			_teamRepository = teamRepository;
		}

		public async Task Init()
		{
			List<League> leagues = new List<League>
			{
				new League("League 1"),
				new League("League 2"),
				new League("League 3")
			};
			
			List<Team> teams = new List<Team>
			{
				new Team("Team 1", leagues[0].Id),
				new Team("Team 2", leagues[0].Id),
				new Team("Team 3", leagues[0].Id),
				new Team("Team 4", leagues[1].Id),
				new Team("Team 5", leagues[1].Id),
				new Team("Team 6", leagues[1].Id),
				new Team("Team 7", leagues[2].Id),
				new Team("Team 8", leagues[2].Id),
				new Team("Team 9", leagues[2].Id),
			};
			

			await _leagueRepository.Add(leagues);
			await _teamRepository.Add(teams);
		}
		
		public async Task<GetAllLeaguesResponse> GetAllLeagues()
		{
			IEnumerable<League> leagues = await _leagueRepository.GetAll();
			IEnumerable<LeagueItem> leagueItem = _mapper.Map<IEnumerable<LeagueItem>>(leagues);

			var view = new GetAllLeaguesResponse {Leagues = leagueItem};
			
			return view;
		}

	}
}