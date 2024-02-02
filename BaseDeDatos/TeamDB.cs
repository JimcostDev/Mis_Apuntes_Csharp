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
        // obtener un elemento por su id
        public Team Get(int id)
        {
            Connect();
            Team team = null;
            string query = "SELECT ID, Name, LeagueID FROM Team " +
                "WHERE ID = @id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(1);
                int leagueID = reader.GetInt32(2);
                team = new Team(id, name, leagueID);
            }
            Close();

            return team;
        }

        // consultar todos los equipos
        public List<Team> GetAll()
        {
            Connect();
            List<Team> Teams = new List<Team>();
            //string query = "SELECT ID, Name, LeagueID FROM Team";
            string query = "EXEC [dbo].[pa_ConsultarEquipos]"; 
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
        // insertar un elemento
        public void Add(Team team)
        {
            Connect();
            //string query = "INSERT INTO Team(Name, LeagueID) " +
            //    "VALUES(@name, @leagueID)";
            string query = "EXEC [dbo].[pa_CrearEquipo] @name, @leagueID";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", team.Name);
            command.Parameters.AddWithValue("@leagueID", team.LeagueID);
            command.ExecuteNonQuery();

            Close();
        }

        // actualizar
        public void Edit(Team team)
        {
            Connect();

            string query = "UPDATE Team SET Name=@name, LeagueID=@leagueID " +
                "WHERE ID=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", team.Name);
            command.Parameters.AddWithValue("@leagueID", team.LeagueID);
            command.Parameters.AddWithValue("@id", team.ID);
            command.ExecuteNonQuery();

            Close();
        }
        // eliminar
        public void Delete(int id)
        {
            Connect();

            string query = "DELETE FROM Team WHERE ID=@id";
            SqlCommand command = new SqlCommand(query, _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            Close();
        }
    }
}

