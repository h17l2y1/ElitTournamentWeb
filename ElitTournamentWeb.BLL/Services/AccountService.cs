using System;
using System.Threading.Tasks;
using ElitTournamentWeb.BLL.Exceptions;
using ElitTournamentWeb.BLL.Helpers.Interfaces;
using ElitTournamentWeb.BLL.Services.Interfaces;
using ElitTournamentWeb.DAL.Repositories.Interfaces;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Auth;

namespace ElitTournamentWeb.BLL.Services
{
	public class AccountService : IAccountService
	{
		private readonly IUserRepository _userRepository;
		private readonly IJwtHelper _jwtHelper;

		public AccountService(IUserRepository userRepository, IJwtHelper jwtHelper)
		{
			_jwtHelper = jwtHelper;
			_userRepository = userRepository;
		}

		public async Task<JwtView> LogIn(LogInRequest logInRequest)
		{
			User user = await UserValidation(logInRequest);
			if (user != null)
			{
				JwtView view = _jwtHelper.CreateToken(user);
				return view;
			}
			throw new UserNotFoundException("Не правильные данные");
		}

		private async Task<User> UserValidation(LogInRequest logInRequest)
		{
			if (string.IsNullOrEmpty(logInRequest.Login) || string.IsNullOrEmpty(logInRequest.Password))
			{
				return null;
			}

			User user = await _userRepository.FindByLogin(logInRequest.Login);
			if (user != null)
			{
				bool passwordIsValid = user.Password == logInRequest.Password ? true : false;

				if (passwordIsValid)
				{
					return user;
				}
			}

			return null;
		}
	}
}