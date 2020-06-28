using AutoMapper;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.League;
using ElitTournamentWeb.ViewModels.PostView;

namespace ElitTournamentWeb.BLL.Config
{
	public class MapperProfile : Profile
	{
		public MapperProfile()
		{

			// CreateMap<Rol, GetAllRolViewItem>();
			
			// CreateMap<SignUpAccountView, User>()
			// 	.ForMember(from => from.UserName, to => to.MapFrom(source => source.Login))
			// 	.ForMember(from => from.Password, to => to.MapFrom(source => source.Password));

			CreateMap<League, LeagueItem>();
			CreateMap<Team, TeamItem>();
			CreateMap<Player, PlayerItem>();
			
			CreateMap<Post, PostItem>();
		}
	}
}