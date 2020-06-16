using System.Data.SqlClient;

namespace ControleEstoque.Web.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;

            //instancia a conexão com o banco de dados
            using(var conexão = new SqlConnection())
            {
                conexão.ConnectionString = "Data source = localhost;Initial Catalog = ControleEstoque; User Id = sa;Password = adailtonlucas12";
                conexão.Open();

                // prepara e executa o comando no banco de dados
                using(var comando = new SqlCommand())
                {
                    comando.Connection = conexão;
                    comando.CommandText = string.Format(
                       "SELECT count(*) FROM Usuario WHERE login = '{0}' AND senha = '{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }
            return ret;
        }
    }
}