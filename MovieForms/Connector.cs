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
    }
}
