namespace FUNCIONARIOS
{
    partial class CadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Civil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.txt_Matricula = new System.Windows.Forms.TextBox();
            this.Mat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_RG = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_Funcao = new System.Windows.Forms.ComboBox();
            this.msk_Cel = new System.Windows.Forms.MaskedTextBox();
            this.cbx_Sexo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Funcionário";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 25);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(260, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado Civil";
            // 
            // cbx_Civil
            // 
            this.cbx_Civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Civil.FormattingEnabled = true;
            this.cbx_Civil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo",
            "Divorciado"});
            this.cbx_Civil.Location = new System.Drawing.Point(12, 67);
            this.cbx_Civil.Name = "cbx_Civil";
            this.cbx_Civil.Size = new System.Drawing.Size(121, 21);
            this.cbx_Civil.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(151, 110);
            this.msk_CPF.Mask = "999.999.999-99";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(121, 20);
            this.msk_CPF.TabIndex = 5;
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Location = new System.Drawing.Point(12, 110);
            this.txt_Matricula.MaxLength = 99999;
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Size = new System.Drawing.Size(121, 20);
            this.txt_Matricula.TabIndex = 4;
            // 
            // Mat
            // 
            this.Mat.AutoSize = true;
            this.Mat.Location = new System.Drawing.Point(12, 94);
            this.Mat.Name = "Mat";
            this.Mat.Size = new System.Drawing.Size(52, 13);
            this.Mat.TabIndex = 6;
            this.Mat.Text = "Matrícula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Função";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.Location = new System.Drawing.Point(12, 194);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(260, 20);
            this.txt_Endereco.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sexo";
            // 
            // txt_RG
            // 
            this.txt_RG.Location = new System.Drawing.Point(151, 233);
            this.txt_RG.Name = "txt_RG";
            this.txt_RG.Size = new System.Drawing.Size(121, 20);
            this.txt_RG.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(151, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "RG";
            // 
            // cbx_Funcao
            // 
            this.cbx_Funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Funcao.FormattingEnabled = true;
            this.cbx_Funcao.Location = new System.Drawing.Point(12, 151);
            this.cbx_Funcao.Name = "cbx_Funcao";
            this.cbx_Funcao.Size = new System.Drawing.Size(260, 21);
            this.cbx_Funcao.TabIndex = 6;
            // 
            // msk_Cel
            // 
            this.msk_Cel.Location = new System.Drawing.Point(12, 233);
            this.msk_Cel.Mask = "(99) 99999-9999";
            this.msk_Cel.Name = "msk_Cel";
            this.msk_Cel.Size = new System.Drawing.Size(121, 20);
            this.msk_Cel.TabIndex = 8;
            // 
            // cbx_Sexo
            // 
            this.cbx_Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Sexo.FormattingEnabled = true;
            this.cbx_Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Assis"});
            this.cbx_Sexo.Location = new System.Drawing.Point(151, 67);
            this.cbx_Sexo.Name = "cbx_Sexo";
            this.cbx_Sexo.Size = new System.Drawing.Size(121, 21);
            this.cbx_Sexo.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_Sexo);
            this.Controls.Add(this.msk_Cel);
            this.Controls.Add(this.cbx_Funcao);
            this.Controls.Add(this.txt_RG);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Matricula);
            this.Controls.Add(this.Mat);
            this.Controls.Add(this.msk_CPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_Civil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "CadastroFuncionario";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.CadastroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Civil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
        private System.Windows.Forms.TextBox txt_Matricula;
        private System.Windows.Forms.Label Mat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_Funcao;
        private System.Windows.Forms.MaskedTextBox msk_Cel;
        private System.Windows.Forms.ComboBox cbx_Sexo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}