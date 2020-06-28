using System;

namespace ElitTournamentWeb.BLL.Exceptions
{
	public class UserNotFoundException : Exception
	{
		public UserNotFoundException()
		{
		}

		public UserNotFoundException(string message) : base(message)
		{
		}

		public UserNotFoundException(string message, Exception ex) : base(message, ex)
		{
		}
	}
}