using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Storage
{
    public class DBConnection
    {
        string connect = "Server=localhost;database=SpicyInvaders;UID=root;password=root;port=6033;";   //Connect string
        string select = "SELECT username, score FROM t_score ORDER BY score DESC LIMIT 5;";             //Select command
        public string username;                                                                         //Take the username of the player
        public int score;                                                                               //Take the score

        public MySqlConnection Connection { get; set; }                                                 //encapsulate the connection

        private static DBConnection _instance = null;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DBConnection Instance()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        /// <summary>
        /// Start a connection with the database
        /// </summary>
        public void connection()
        {
            Connection = new MySqlConnection(connect);                      //start a connection

            try                                                             //try opening the connection
            {
                Connection.Open();

                Debug.WriteLine("Connexion à la base de donnée réussi");    //Message that say that the connection work
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Erreur avec la base de donnée");           //Message that say there's an error
            }

        }

        /// <summary>
        /// Insert in the database a score and a username
        /// </summary>
        public void Add()
        {
            string parameters = "INSERT INTO t_score(score, username) VALUES (" + score + ", '" + username + "');"; //string having the insert command
            MySqlCommand cmd = new MySqlCommand(parameters, Connection);                                            //Doing the string command
            MySqlDataReader reader = cmd.ExecuteReader();                                                           //Reading the command
            reader.Read();                                                                                          //Start reading the command
            reader.Close();                                                                                         //End the reading of the command
        }

        /// <summary>
        /// Display the 5 best score
        /// </summary>
        public void Top5()
        {
            MySqlCommand cmd;
            MySqlDataReader dataReader;
            cmd = new MySqlCommand(select, Connection);         //Doing the select command

            dataReader = cmd.ExecuteReader();
            while(dataReader.Read())                            //Read every information, display them
            {
                Console.WriteLine(dataReader.GetValue(0) + " || " + dataReader.GetValue(1));
            }
            dataReader.Close();                                 //End the reading
        }
    }
}