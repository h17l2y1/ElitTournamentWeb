namespace ElitTournamentWeb.ViewModels
{
    public class UserView
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public CityView From { get; set; }
        public string NotBeingSaved { get; set; }
    }
    
    public class CityView
    {
        public string Name { get; set; }
    }
}