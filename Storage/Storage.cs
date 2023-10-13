using MySql;
using MySql.Data;
using System.Data.SqlClient;

using (SqlConnection connection = new SqlConnection(/*nom de la db?*/))
{
    String query = "INSERT INTO db_SpicyInvaders (id,username,score) VALUES (@id,@username,@score)";

    using (SqlCommand command = new SqlCommand(query, connection))
    {
        command.Parameters.AddWithValue("@id", "");
        command.Parameters.AddWithValue("@username", "abc");
        command.Parameters.AddWithValue("@score", "abc");

        connection.Open();
        int result = command.ExecuteNonQuery();

        // Check Error
        if (result < 0)
            Console.WriteLine("Error inserting data into Database!");
    }
}