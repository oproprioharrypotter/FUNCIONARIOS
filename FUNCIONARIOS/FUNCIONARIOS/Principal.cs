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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void fUNCIONÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario tela = new CadastroFuncionario();
            tela.Show();
        }

        private void dEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamento_Cadastrar tela = new Departamento_Cadastrar();
            tela.Show();
        }

        private void uSUÁRIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int permissao = Usuario.Login;
            if (permissao == 0)
            {
                Cadastrar_Usuario tela = new Cadastrar_Usuario();
                tela.Show();
            }
            else
            {
                MessageBox.Show("USUÁRIO SEM PERMISSÃO PARA CADASTRO!");
            }
        }
    }
}
