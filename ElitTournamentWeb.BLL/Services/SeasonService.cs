using System;
using System.Collections;
using System.Threading.Tasks;
using AutoMapper;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interface;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Season;

namespace ElitTournamentWeb.BLL.Services
{
	public class SeasonService : ISeasonService
	{
		private readonly IMapper _mapper;
		private readonly ISeasonRepository _seasonRepository;

		public SeasonService(IMapper mapper, ISeasonRepository seasonRepository)
		{
			_mapper = mapper;
			_seasonRepository = seasonRepository;
		}

		public async Task Create(CreateSeasonRequest requset)
		{
			Season season = _mapper.Map<Season>(requset);
			// await _seasonRepository.CreateAsync(season);
		}

		public async Task GetAll()
		{
			// IEnumerable seasons = await _seasonRepository.GetAll();
		}
	}
}