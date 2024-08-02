using ADO.HomeworkSQL.Models;
using ADO.HomeworkSQL.Services;
using System.Data;
using System.Data.SqlClient;

string connectionString = "server = DESKTOP-1TK00A3;database = ADO_Homework; trusted_connection = true; integrated security = true";





//using (SqlConnection sqlConnection = new SqlConnection(connectionString))
//{
//    //sqlConnection.Open();
//    //string command = "INSERT INTO Users values('Fatima', 'fayton')";
//    //SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);
//    //sqlCommand.ExecuteNonQuery();
//    //sqlConnection.Close();

//    string queryCommand = "Select * from Users";
//    SqlCommand command1 = new SqlCommand(queryCommand, sqlConnection);
//    SqlDataAdapter adapter = new SqlDataAdapter(queryCommand, sqlConnection);

//    DataTable dataTable = new DataTable();
//    adapter.Fill(dataTable);
//    foreach (DataRow item in dataTable.Rows)
//    {
//        Console.WriteLine(item["Id"].ToString() + " " + item["Name"].ToString() + " " + item["Username"].ToString());
//    }
//}



//User user = new User()
//{
//    Name = "Fatima",
//    Username = "fayton"
//};
//User user2 = new User()
//{
//    Name = "Gunel",
//    Username = "ruxel"
//};

UserService userService = new UserService();
//userService.Create(user);
//userService.Create(user2);


User userToUpdate = new User()
{
    Id = 5,
    Name = "Fatima",
    Username = "faytonn_"
};
userService.Update(userToUpdate);




