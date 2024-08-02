using System.Data;
using System.Data.SqlClient;

namespace ADO.HomeworkSQL.DAL
{
    public class AppDbContext
    {
        static readonly string connectionString = "server = DESKTOP-1TK00A3;database = ADO_Homework; trusted_connection = true; integrated security = true";

        SqlConnection connection = new SqlConnection(connectionString);


        public int ExecuteNonQuery(string command)
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand(command, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();

            return result;
        }

        public DataTable QueryExc(string command)
        {
            connection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            connection.Close();

            return dt;
        }
    }
}
