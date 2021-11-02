using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.League;

namespace ElitTournamentWeb.BLL.Services
{
	public class LeagueService : ILeagueService
	{
		private readonly IMapper _mapper;
		private readonly ILeagueRepository _leagueRepository;
		
		public LeagueService(IMapper mapper, ILeagueRepository leagueRepository)
		{
			_mapper = mapper;
			_leagueRepository = leagueRepository;
		}

		public async Task CreateLeagues()
		{
			string sb = "[{\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8975253Z\",\"Name\":\"Orbean\",\"Teams\":[{\"Position\":0,\"Icon\":null,\"Name\":\"Gaptec\",\"Played\":9,\"Won\":0,\"Drawn\":0,\"Lost\":9,\"Goals\":12,\"GoalDifference\":5,\"Points\":0,\"Players\":[{\"FirstName\":\"Keri\",\"LastName\":\"Thornton\",\"Age\":36,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Cross\",\"LastName\":\"White\",\"Age\":34,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Horne\",\"LastName\":\"Bernard\",\"Age\":38,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":1,\"Icon\":null,\"Name\":\"Plasmosis\",\"Played\":9,\"Won\":5,\"Drawn\":2,\"Lost\":2,\"Goals\":22,\"GoalDifference\":9,\"Points\":17,\"Players\":[{\"FirstName\":\"Golden\",\"LastName\":\"Baldwin\",\"Age\":31,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Lenore\",\"LastName\":\"Armstrong\",\"Age\":37,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Lina\",\"LastName\":\"Rosales\",\"Age\":40,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":2,\"Icon\":null,\"Name\":\"Cinaster\",\"Played\":9,\"Won\":7,\"Drawn\":1,\"Lost\":1,\"Goals\":12,\"GoalDifference\":7,\"Points\":22,\"Players\":[{\"FirstName\":\"Avis\",\"LastName\":\"Bean\",\"Age\":20,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Annabelle\",\"LastName\":\"Craft\",\"Age\":31,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Kristy\",\"LastName\":\"Navarro\",\"Age\":29,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"}]},{\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8975253Z\",\"Name\":\"Eventix\",\"Teams\":[{\"Position\":0,\"Icon\":null,\"Name\":\"Steeltab\",\"Played\":9,\"Won\":0,\"Drawn\":6,\"Lost\":3,\"Goals\":19,\"GoalDifference\":16,\"Points\":6,\"Players\":[{\"FirstName\":\"Chen\",\"LastName\":\"Wooten\",\"Age\":33,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Jeanie\",\"LastName\":\"Hancock\",\"Age\":33,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Rose\",\"LastName\":\"Lambert\",\"Age\":23,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":1,\"Icon\":null,\"Name\":\"Datagene\",\"Played\":9,\"Won\":5,\"Drawn\":4,\"Lost\":0,\"Goals\":18,\"GoalDifference\":21,\"Points\":19,\"Players\":[{\"FirstName\":\"Maynard\",\"LastName\":\"Yates\",\"Age\":38,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Montgomery\",\"LastName\":\"Brennan\",\"Age\":35,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Moses\",\"LastName\":\"Sampson\",\"Age\":25,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":2,\"Icon\":null,\"Name\":\"Xanide\",\"Played\":9,\"Won\":9,\"Drawn\":6,\"Lost\":-6,\"Goals\":22,\"GoalDifference\":11,\"Points\":33,\"Players\":[{\"FirstName\":\"Lowe\",\"LastName\":\"Bentley\",\"Age\":24,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Imogene\",\"LastName\":\"Marks\",\"Age\":40,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Janine\",\"LastName\":\"Kelly\",\"Age\":29,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"}]},{\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8975253Z\",\"Name\":\"Isologix\",\"Teams\":[{\"Position\":0,\"Icon\":null,\"Name\":\"Boink\",\"Played\":9,\"Won\":6,\"Drawn\":1,\"Lost\":2,\"Goals\":23,\"GoalDifference\":17,\"Points\":19,\"Players\":[{\"FirstName\":\"Casey\",\"LastName\":\"Larson\",\"Age\":34,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Case\",\"LastName\":\"Raymond\",\"Age\":24,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Miranda\",\"LastName\":\"Vasquez\",\"Age\":40,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":1,\"Icon\":null,\"Name\":\"Enquility\",\"Played\":9,\"Won\":6,\"Drawn\":1,\"Lost\":2,\"Goals\":11,\"GoalDifference\":9,\"Points\":19,\"Players\":[{\"FirstName\":\"Blanche\",\"LastName\":\"Solis\",\"Age\":30,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Lisa\",\"LastName\":\"Michael\",\"Age\":27,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Julie\",\"LastName\":\"Mosley\",\"Age\":21,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"},{\"Position\":2,\"Icon\":null,\"Name\":\"Geostele\",\"Played\":9,\"Won\":6,\"Drawn\":3,\"Lost\":0,\"Goals\":8,\"GoalDifference\":9,\"Points\":21,\"Players\":[{\"FirstName\":\"Banks\",\"LastName\":\"Nunez\",\"Age\":40,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Michelle\",\"LastName\":\"Pollard\",\"Age\":22,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"},{\"FirstName\":\"Mcclain\",\"LastName\":\"Bass\",\"Age\":40,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8981319Z\"}],\"LeagueId\":1,\"League\":null,\"Id\":0,\"CreationDate\":\"2020-06-26T12:18:08.8977092Z\"}]}]";
			List<League> leagues = JsonSerializer.Deserialize<List<League>>(sb);

			await _leagueRepository.Add(leagues);
		}
		
		public async Task<GetAllLeaguesResponse> GetAllLeagues()
		{
			IEnumerable<League> leagues = await _leagueRepository.GetAll();
			IEnumerable<LeagueItem> leagueItem = _mapper.Map<IEnumerable<LeagueItem>>(leagues);

			var view = new GetAllLeaguesResponse {Leagues = leagueItem};
			
			return view;
		}
		
		public async Task CreateLeagues2()
		{
			List<League> leagues = new List<League>
			{
				new League("Test League1"),
				new League("Test League2")
			};

			await _leagueRepository.Add(leagues);
		}
	}
}