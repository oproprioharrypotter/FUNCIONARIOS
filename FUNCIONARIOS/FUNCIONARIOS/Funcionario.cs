using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCIONARIOS
{
    class Funcionario
    {
        private int id;
        private string nome;
        private string estadoCivil;
        private string sexo;
        private string matricula;
        private string cpf;
        private int idDepartamento;
        private string endereco;
        private string celular;
        private string rg;

        public int Id { get => id;}
        public string Nome { get => nome; set => nome = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int IdDepartamento { get => idDepartamento; set => idDepartamento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Rg { get => rg; set => rg = value; }
    }
}
