using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNCIONARIOS
{
    public partial class Login : Form
    {   
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Persist Security Info=False;Server=localhost;Database=faculdade1;uid=root;pwd=admin;");
        MySqlDataAdapter adapter;
        DataTable tabela = new DataTable();

        private void button2_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("select nome_login, senha from login where nome_login='" + txt_Login.Text + "' and senha='" + txt_Senha.Text + "';", conn);
            adapter.Fill(tabela);

            if (tabela.Rows.Count <= 0)
            {
                MessageBox.Show("USUÁRIO OU SENHA INVÁLIDOS");
            }
            else
            {
                string scomand = "SELECT tipo_permissao FROM login WHERE nome_login = '" + txt_Login.Text + "';";
                MySqlDataReader leitor = null;
                conn.Open();

                MySqlCommand comando = new MySqlCommand(scomand, conn);

                leitor = comando.ExecuteReader();

                while (leitor.Read())
                {
                    int tipo_permissao = (int)leitor["tipo_permissao"];
                    Usuario.Login = tipo_permissao;
                }
                this.Hide();
                Form f = new Principal();
                f.Closed += (s, args) => this.Close();
                f.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void acaoBotao(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
            else if (e.KeyValue.Equals(27))
            {
                button1_Click(sender, e);
            }
        }
    }
}
