using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONARIOS
{
    class Departamento
    {
        private string nome_departamento;
        private string descricao;

        public bool CadastrarDepartamento(string Nome_departamento, string Descricao)
        {
            nome_departamento = Nome_departamento;
            descricao = Descricao;

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;Server=localhost;Database=faculdade1;uid=root;pwd=admin;");
            conn.Open();

            string scomand = "INSERT INTO Departamento (nome_departamento, descricao) values(@nome_departamento, @descricao);";
            MySqlCommand comando = new MySqlCommand(scomand, conn);

            comando.Parameters.AddWithValue("@nome_departamento", nome_departamento);
            comando.Parameters.AddWithValue("@descricao", descricao);

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
