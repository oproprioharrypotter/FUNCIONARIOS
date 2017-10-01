using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNCIONARIOS
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Salvar cadastrar = new Salvar();
                bool logica = cadastrar.salvarDados(txt_Nome.Text, cbx_Civil.Text, txt_Matricula.Text, msk_CPF.Text,
                    cbx_Sexo.Text, cbx_Funcao.Text, txt_Endereco.Text, msk_Cel.Text, txt_RG.Text);
                if (logica)
                {
                    MessageBox.Show("FUNCIONÁRIO CADASTRADO COM SUCESSO!");
                }
                else
                {
                    MessageBox.Show("Não funcionou!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Persist Security Info = False; Server = localhost; Database = faculdade1; uid = root; pwd = admin; ");
            MySqlCommand comando = new MySqlCommand("SELECT nome_departamento FROM Departamento;", conn);
            conn.Open();
            MySqlDataReader dr = comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);

            cbx_Funcao.DisplayMember = "nome_departamento";
            cbx_Funcao.DataSource = dt;

            conn.Close();
        }
        //estado_civil
        //matricula 
        //cpf
        //sexo
        //funcao
        //endereco
        //celular
        //rg
    }

}
