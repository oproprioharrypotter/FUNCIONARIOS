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
    public partial class Cadastrar_Usuario : Form
    {
        public Cadastrar_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = txt_Senha.Text;
            string novaSenha = txt_NovaSenha.Text;

            if (senha != novaSenha)
            {
                MessageBox.Show("SENHAS NÃO CONFEREM!");
            }
            else
            {
                try
                {
                    Usuario_Cadastrar usuario = new Usuario_Cadastrar();
                    bool logica = usuario.CadastroUsuario(txt_Usuario.Text, txt_Senha.Text, Convert.ToInt16(cbx_Permissao.Text));

                    if (logica)
                    {
                        MessageBox.Show("USUÁRIO CADASTRADO COM SUCESSO");
                        this.Dispose();
                    }
                    else
                    {

                        string nome = txt_Usuario.Text.Trim();
                        if (nome == "")
                        {
                            MessageBox.Show("FORMATO DE NOME DE USUÁRIO INCORRETO!");
                        }
                        if (cbx_Permissao.Text == "")
                        {
                            MessageBox.Show("SELECIONAR TIPO DE PERMISSÃO!");
                        }

                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
