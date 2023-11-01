using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Storage
{
    public class DBConnection
    {
        string str = "Server=localhost;database=SpicyInvaders;UID=root;password=root;port=6033;";
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
            Connection = new MySqlConnection(str);          //Lancer une connection

            try                                             //Essayer de s'y connecter
            {
                Connection.Open();

                Debug.WriteLine("Connexion à la base de donnée réussi");    //Affiche à la sortie, confirme la connexion
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine("erreur de connexion à la base de donnée");                //Message erreur à la sortie si impossible de se connecter à la db
            }

        }

        public void Add()
        {
            string parameters = "INSERT INTO t_score(score, username) VALUES (" + score + ", '" + username + "');";
            MySqlCommand cmd = new MySqlCommand(parameters, Connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Connection.Close();
        }
    }
}