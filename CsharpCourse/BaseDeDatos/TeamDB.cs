using System.Data.SqlClient;

namespace BaseDeDatos
{
    public  class TeamDB : DB
    {
        // Usamos el ctor del padre (DB) desde el hijo (TeamDB)
        public TeamDB(string server, string db, string user, string password) :
            base(server, db, user, password)
        {

        }

        // consultar todos los equipos
        public List<Team> GetAll()
        {
            Connect();
            List<Team> Teams = new List<Team>();
            string query = "SELECT ID, Name, LeagueID FROM Team";
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int leagueID = reader.GetInt32(2);
                Teams.Add(new Team(id, name, leagueID));
            }

            Close();

            return Teams;
        }
    }
}
