﻿using ElitTournamentWeb.BLL.Helpers.Interfaces;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ElitTournamentWeb.DAL.Config;
using ElitTournamentWeb.Entities.Entities;
using ElitTournamentWeb.ViewModels.Auth;

namespace ElitTournamentWeb.BLL.Helpers
{
	public class JwtHelper : IJwtHelper
	{
		private readonly AuthOptions _authOptions;

		public JwtHelper(IOptions<AuthOptions> authOptions)
		{
			_authOptions = authOptions.Value;
		}
		
		public JwtView CreateToken(User user)
		{
			ClaimsIdentity identity = GetIdentity(user);
			JwtSecurityToken jwt = GetToken(identity);
			string stringToken = new JwtSecurityTokenHandler().WriteToken(jwt);
			JwtView result = new JwtView() {AccessToken = stringToken};
			return result;
		}

		private JwtSecurityToken GetToken(ClaimsIdentity identity)
		{
			var key = Encoding.ASCII.GetBytes(_authOptions.Key);
			var jwt = new JwtSecurityToken(
				issuer: _authOptions.Issuer,
				audience: _authOptions.Audience,
				claims: identity.Claims,
				expires: DateTime.UtcNow.AddDays(_authOptions.LifeTime),
				signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
			);
			return jwt;
		}

		private ClaimsIdentity GetIdentity(User user)
		{
			var claimsList = new List<Claim>
			{
				new Claim("login", user.Login),
				new Claim("id",user.Id.ToString()),
				new Claim("isAdmin", user.IsAdmin.ToString()),
				new Claim("fullName", user.FullName)
			};
			ClaimsIdentity claimsIdentity = new ClaimsIdentity(claimsList, "Token");
			return claimsIdentity;
		}
	}
}