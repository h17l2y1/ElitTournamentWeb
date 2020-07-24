using AutoMapper;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.League;
using ElitTournamentWeb.ViewModels.Player;
using ElitTournamentWeb.ViewModels.Post;
using ElitTournamentWeb.ViewModels.Season;
using ElitTournamentWeb.ViewModels.Team;

namespace ElitTournamentWeb.BLL.Config
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{
			
			// CreateMap<SignUpAccountView, User>()
			// 	.ForMember(from => from.UserName, to => to.MapFrom(source => source.Login))
			// 	.ForMember(from => from.Password, to => to.MapFrom(source => source.Password));

			CreateMap<League, LeagueItem>().ReverseMap();
			CreateMap<Team, TeamItem>().ReverseMap();
			CreateMap<Player, PlayerItem>().ReverseMap();
			
			CreateMap<Post, PostItem>();
			CreateMap<UpdatePostRequest, Post>();
			CreateMap<UpdateManyPostItemRequest, Post>();
			
			
			CreateMap<CreateSeasonRequest, Season>();
			CreateMap<UpdateSeasonRequest, Season>();
			// CreateMap<Season, GetSeasonResponse>();
			CreateMap<GetSeasonResponse, Season>().ReverseMap();
			
		}
	}
}