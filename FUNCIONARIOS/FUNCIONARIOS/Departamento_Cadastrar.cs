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
    public partial class Departamento_Cadastrar : Form
    {
        public Departamento_Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Departamento departamento = new Departamento();
                bool logica = departamento.CadastrarDepartamento(txt_Departamento.Text, txt_Descricao.Text);

                string nome = txt_Departamento.Text.Trim();

                if (logica)
                {
                    MessageBox.Show("DEPARTAMENTO CADASTRADO COM SUCESSO!");
                    this.Dispose();
                }
                else
                {
                    if (nome == "" || nome.Length > 99)
                    {
                        MessageBox.Show("FORMATO DE NOME DE DEPARTAMENTO INCORRETO!");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
