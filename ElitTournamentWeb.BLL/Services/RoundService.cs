using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Round;

namespace ElitTournamentWeb.BLL.Services
{
	public class RoundService : IRoundService
	{
		private readonly IMapper _mapper;
		private readonly IRoundRepository _roundRepository;

		public RoundService(IMapper mapper, IRoundRepository roundRepository)
		{
			_mapper = mapper;
			_roundRepository = roundRepository;
		}

		public async Task Create(CreateRoundRequest requset)
		{
			Round round = _mapper.Map<Round>(requset);
			await _roundRepository.CreateAsync(round);
		}

		public async Task<GetAllRoundsResponse> GetAll(int seasonId)
		{
			IEnumerable<Round> rounds = await _roundRepository.GetAll(seasonId);
			IEnumerable<RoundItem> roundItems = _mapper.Map<IEnumerable<RoundItem>>(rounds);
			var response = new GetAllRoundsResponse(roundItems);
			return response;
		}
		
	}
}