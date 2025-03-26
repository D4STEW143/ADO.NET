using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace MovieForms
{
    internal class Connector
    {
        readonly string CONNECTION_STRING;
        readonly SqlConnection connection;
        public Connector(string connection_string)
        {
            this.CONNECTION_STRING = connection_string;
            this.connection = new SqlConnection(connection_string);
        }
        public Connector() : this(ConfigurationManager.ConnectionStrings["Movies_VPD_311"].ConnectionString) { }
        public List<string> GetTablesNames()
        {
            //Данный метод позволяет получить имена всех таблиц, не зависимо от их количества.
            List<string> toReturn = new List<string>();
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                toReturn.Add(Reader.GetString(0));
            }
            connection.Close();
            return toReturn;
        }

        public DataTable GetAllData(string table_name)
        {
            DataTable result = new DataTable();
            string query = $"SELECT * FROM {table_name}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(result);
            return result;
        }

        public void InsertDataToDirectors( string first_name, string last_name)
        {
            string condition = $" last_name=N'{last_name}' AND first_name=N'{first_name}'";
            string query =
                $"INSERT Directors(first_name, last_name) VALUES (N'{first_name}', N'{last_name}')";
            string cmd = $"IF NOT EXISTS (SELECT director_id FROM Directors WHERE {condition}) BEGIN {query} END";
            Console.WriteLine(cmd);
            SqlCommand command = new SqlCommand(cmd, connection);
            Console.WriteLine(query);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        
        public void InsertDataToMovies(string title, string release_date, string director_id)
        {
            string condition = $" title=N'{title}' AND release_date=N'{release_date}'";
            string query =
                $"INSERT Movies(title, release_date, director) VALUES (N'{title}', N'{release_date}', N'{director_id}')";
            string cmd = $"IF NOT EXISTS (SELECT movie_id FROM Movies WHERE {condition}) BEGIN {query} END";
            Console.WriteLine(cmd);
            SqlCommand command = new SqlCommand(cmd, connection);
            Console.WriteLine(query);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void DeleteData(string item_id, string table_name)
        {
            string tName_correction = table_name.Remove(table_name.Length - 1, 1);//удаляет последнюю букву слова, чтобы было правильное написание
            string exact_table_id = string.Concat(tName_correction.ToLower(), "_id");
            string query = $"DELETE FROM {table_name} WHERE {exact_table_id} = {item_id}";
            Console.WriteLine(query);
            SqlCommand command = new SqlCommand (query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
