using ADO.HomeworkSQL.DAL;
using ADO.HomeworkSQL.Models;
using System.Data;

namespace ADO.HomeworkSQL.Services
{
    public class UserService
    {
        AppDbContext appContext = new AppDbContext();


        public void Create(User user)
        {
            string command = $"INSERT INTO Users VALUES ('{user.Name}', '{user.Username}')";
            var result = appContext.ExecuteNonQuery(command);
            if(result > 0)
            {
                Console.WriteLine($"Data successfully added, '{user.Name}'");
            } 
            else
            {
                Console.WriteLine("Data cannot be added, try again.");
            }
        }

        public void Update(User user)
        {
            string command = $"UPDATE Users SET Name='{user.Name}', Username='{user.Username}' WHERE Id={user.Id}";
            appContext.ExecuteNonQuery(command);
        }

        public void Delete(int id)
        {
            string command = $"DELETE FROM Users WHERE Id={id}";
            appContext.ExecuteNonQuery(command);
        }

        public List<User> GetAll()
        {
            string command = "SELECT * FROM Users";
            DataTable dataTable = appContext.QueryExc(command);

            List<User> users = new List<User>();
            foreach (DataRow item in dataTable.Rows)
            {
                Console.WriteLine(item["Id"].ToString() + " " + item["Name"].ToString() + " " + item["Username"].ToString());
            }
            return users;
        }
        

        public User GetById(int id)
        {
            string command = $"SELECT * FROM Users WHERE Id = {id}";
            DataTable dataTable = appContext.QueryExc(command);

            if(dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];

                User user = new User();

                user.Id = (int)row["Id"];
                user.Name = row["Name"].ToString();
                user.Username = row["Username"].ToString();

                return user;

            }
            else
            {
                Console.WriteLine("User not found.");
                return null;
            }


        }
        

    }
}
