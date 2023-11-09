namespace BaseDeDatos
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int LeagueID { get; set; }

        public Team(int id, string name, int leagueID)
        {
            this.ID = id;
            this.Name = name;
            this.LeagueID = leagueID;
        }

        public Team(string name, int leagueID)
        {
            this.Name = name;
            this.LeagueID = leagueID;
        }
    }
}
