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
            

            SqlCommand cmd = new SqlCommand("INSERT INTO Userr(Email, Password) VALUES(@email, @password)", con);
            cmd.Parameters.AddWithValue("@email", userr.Email);
            cmd.Parameters.AddWithValue("@password", userr.Password);

            con.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        internal User GetUserByEmailAndPassword(string email, string password)
        {
            using SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT Email, Password FROM Userr WHERE Email=@Email AND Password=@Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User
                {
                    Email = reader["Email"].ToString(),
                    Password = reader["Password"].ToString()
                };
            }
            return null; // user not found
        }

    }
}
