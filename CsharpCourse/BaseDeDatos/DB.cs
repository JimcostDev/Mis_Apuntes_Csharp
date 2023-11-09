using System.Data.SqlClient;

namespace BaseDeDatos
{
    public abstract class DB
    {
        public string _connectionstring;
        protected SqlConnection _connection;
        public DB(string server, string db_name, string user, string password)
        {
            _connectionstring = $"Data Source={server}; Initial Catalog={db_name}; User={user}; Password={password}";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionstring);
            _connection.Open();
        }

        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
                _connection.Close();
        }
    }
}
