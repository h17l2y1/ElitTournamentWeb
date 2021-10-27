namespace ElitTournamentWeb.Entities.Entities
{
	public class UserOld : BaseEntity
	{
		public string Login { get; set; }
		public string FullName { get; set; }
		public string Password { get; set; }
		public bool isAdmin { get; set; }
	}
}