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

        public void connection()
        {
            Connection = new MySqlConnection(connect);          //Lancer une connection

            try                                             //Essayer de s'y connecter
            {
                Connection.Open();

                Debug.WriteLine("Connexion à la base de donnée réussi");    //Affiche à la sortie, confirme la connexion
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("Erreur avec la base de donnée");                //Message erreur à la sortie si impossible de se connecter à la db
            }

        }

        public void Add()
        {
            string parameters = "INSERT INTO t_score(score, username) VALUES (" + score + ", '" + username + "');"; //string contenant la commande
            MySqlCommand cmd = new MySqlCommand(parameters, Connection);                                            //Effectuer la commande du string dans la connection de la DB
            MySqlDataReader reader = cmd.ExecuteReader();                                                           //Lire la commande
            reader.Read();
            reader.Close();
        }

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