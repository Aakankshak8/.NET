using _09Day_Assignment.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Day_Assignment.Dal
{
    internal class UserDAL
    {
        private string connectionString =
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=aakanksha;Integrated Security=True";

        internal int CreateUser(User userr)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            string query =
                "INSERT INTO Userr (Email, Password) VALUES (@email, @password)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", userr.Email);
            cmd.Parameters.AddWithValue("@password", userr.Password);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            using SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(
                "SELECT Email, Password FROM Userr", con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString()
                });
            }
            return users;
        }
    }
}
