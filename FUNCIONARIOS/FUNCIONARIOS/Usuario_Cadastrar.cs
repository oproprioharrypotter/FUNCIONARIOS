using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONARIOS
{
    class Usuario_Cadastrar
    {
        private string nome_login;
        private string senha;
        private int permissao;

        public bool CadastroUsuario(string Usuario, string Senha, int Permissao)
        {
            nome_login = Usuario;
            senha = Senha;
            permissao = Permissao;

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;Server=localhost;Database=faculdade1;uid=root;pwd=admin;");
            conn.Open();

            string scomand = "INSERT INTO login (nome_login, senha, tipo_permissao) values(@nome_login, @senha, @permissao);";
            MySqlCommand comando = new MySqlCommand(scomand, conn);

            comando.Parameters.AddWithValue("@nome_login", nome_login);
            comando.Parameters.AddWithValue("@senha", senha);
            comando.Parameters.AddWithValue("@permissao", permissao);

            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
