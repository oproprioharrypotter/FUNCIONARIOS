using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONARIOS
{
    class Salvar
    {
        private string nome;
        private string estado_civil;
        private string matricula;
        private string cpf;
        private string sexo;
        private string funcao;
        private string endereco;
        private string celular;
        private string rg;

        public bool salvarDados(string Nome, string estadoCivil, string Matricula, string Cpf, string Sexo,
            string Funcao, string Endereco, string Celular, string Rg)
        {
            nome = Nome;
            estado_civil = estadoCivil;
            matricula = Matricula;
            cpf = Cpf;
            sexo = Sexo;
            funcao = Funcao;
            endereco = Endereco;
            celular = Celular;
            rg = Rg;

            MySqlConnection conn = new MySqlConnection("Persist Security Info=False;Server=localhost;Database=faculdade1;uid=root;pwd=admin;");
            conn.Open();

            //estado_civil
            //matricula 
            //cpf
            //sexo
            //funcao
            //endereco
            //celular
            //rg

            string scomand = "INSERT INTO funcionarios (nome, estado_civil, matricula, cpf, sexo, funcao, endereco, celular, rg) values(@nome, @estado_civil, @matricula, @cpf, @sexo, @funcao, @endereco, @celular, @rg);";
            MySqlCommand comando = new MySqlCommand(scomand, conn);

            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@estado_civil", estado_civil);
            comando.Parameters.AddWithValue("@matricula", matricula);
            comando.Parameters.AddWithValue("@cpf", cpf);
            comando.Parameters.AddWithValue("@sexo", sexo);
            comando.Parameters.AddWithValue("@funcao", funcao);
            comando.Parameters.AddWithValue("@endereco", endereco);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@rg", rg);


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
