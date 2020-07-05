using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Team;

namespace ElitTournamentWeb.BLL.Services
{
	public class TeamService : ITeamService
	{
		private readonly IMapper _mapper;
		private readonly ITeamRepository _teamRepository;
		
		public TeamService(IMapper mapper, ITeamRepository teamRepository)
		{
			_mapper = mapper;
			_teamRepository = teamRepository;
		}
		
		public async Task<GetTeamsAllResponse> GetAll()
		{
			IEnumerable<Team> teams = await _teamRepository.GetAll();
			IEnumerable<TeamItem> teamView = _mapper.Map<IEnumerable<TeamItem>>(teams);
			var view = new GetTeamsAllResponse(teamView);

			return view;
		}
		
		public async Task Create(CreateTeamRequest request)
		{
			Team newTeam = _mapper.Map<Team>(request);
			await _teamRepository.CreateAsync(newTeam);
		}
		
		public async Task Update(UpdateTeamRequest request)
		{
			Team team = _mapper.Map<Team>(request);
			await _teamRepository.Update(team);
		}
	}
}