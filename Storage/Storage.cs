using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Storage
{
    public class DBConnection
    {
        string connect = "Server=localhost;database=SpicyInvaders;UID=root;password=root;port=6033;";
        string select = "SELECT username, score FROM t_score ORDER BY score DESC LIMIT 5;";
        public string username;
        public int score;

        public MySqlConnection Connection { get; set; }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        /// <summary>
        /// Start a connection
        /// </summary>
        public void connection()
        {
            Connection = new MySqlConnection(connect);          //Start a connection

            try                                             //Try connecting
            {
                Connection.Open();

                Debug.WriteLine("Connexion à la base de donnée réussi");    //Display the connection state
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Erreur avec la base de donnée");                //Display an error message
            }

        }

        /// <summary>
        /// Closing the connection to the database
        /// </summary>
        public void connectionClose()
        {
            Connection?.Close();
        }

        /// <summary>
        /// Add data in the database
        /// </summary>
        public void Add()
        {
            string parameters = "INSERT INTO t_score(score, username) VALUES (" + score + ", '" + username + "');"; //string containing the command
            MySqlCommand cmd = new MySqlCommand(parameters, Connection);                                            //Doing the command in the database
            MySqlDataReader reader = cmd.ExecuteReader();                                                           //Reading the command
            reader.Read();
            reader.Close();
        }

        /// <summary>
        /// Displaying the 5 best player
        /// </summary>
        public void Top5()
        {
            MySqlCommand cmd;
            MySqlDataReader dataReader;
            cmd = new MySqlCommand(select, Connection);
            
            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())
            {
                Console.WriteLine(dataReader.GetValue(0) + " || " + dataReader.GetValue(1));
            }
            dataReader.Close();
        }
    }
}