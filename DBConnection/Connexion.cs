using System.Data;
using System.Data.SqlClient;

namespace DBConnection
{
    public class Connexion
    {
        private readonly string _connectionString;

        public Connexion(string connectionString)
        {
            _connectionString = connectionString;
        }


        private static SqlCommand CreateCommand(Command command, SqlConnection connexion)
        {
            // créer la commande de base de l'argument recu en parametre
                SqlCommand cmd = connexion.CreateCommand();
                cmd.CommandText = command.Query;
                if (command.IsStireProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //SqlParameter returnParameter = new SqlParameter();
                    //returnParameter.ParameterName = "ReturnParameter";
                    
                }

                foreach (KeyValuePair<string, object> kvp in command.Parameters)
                {
                    // creer un parametre et lui assigner chaque clé et chaque valeur
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = kvp.Key;
                    parameter.Value = kvp.Value;
                    //j'ajoute le parametre à ma sqlcommand
                    cmd.Parameters.Add(parameter);
                }
    
                return cmd;
            
        }

        public int ExecuteNonQuery(Command command)
        {
            // crée la connection 
            using (SqlConnection connexion = new SqlConnection())
            {
                connexion.ConnectionString = _connectionString;
                using (SqlCommand cmd = CreateCommand(command,connexion))
                {
                    connexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
            
        }

        public object? ExecuteScalar(Command command)
        {
            // crée la connection 
            using (SqlConnection connexion = new SqlConnection())
            {
                connexion.ConnectionString = _connectionString;
                using (SqlCommand cmd = CreateCommand(command, connexion))
                {
                    object? result = cmd.ExecuteScalar();
                    return result is DBNull ? null : result;
                }
            }
        }

        public DataTable GetDataTable(Command command)
        {
            // crée la connection 
            using (SqlConnection connexion = new SqlConnection())
            {
                connexion.ConnectionString = _connectionString;
                using (SqlCommand cmd = CreateCommand(command, connexion))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }

                }
            }
        }
    }
}