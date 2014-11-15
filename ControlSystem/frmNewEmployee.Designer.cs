namespace ControlSystem
{
    partial class frmNewEmployee
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
            this.components = new System.ComponentModel.Container();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.estadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUF
            // 
            this.cboUF.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.estadosBindingSource, "sigla", true));
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(508, 148);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(240, 21);
            this.cboUF.TabIndex = 8;
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataSource = typeof(ControlSystem.estados);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(508, 44);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(240, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ADMINISTRAÇÃO",
            "BALCÃO",
            "GERENTE"});
            this.cboStatus.Location = new System.Drawing.Point(155, 252);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(240, 21);
            this.cboStatus.TabIndex = 14;
            this.cboStatus.Text = "Selecione o Perfil";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(155, 174);
            this.txtCEP.Mask = "00000-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(240, 20);
            this.txtCEP.TabIndex = 9;
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(154, 226);
            this.txtNascimento.Mask = "00/00/0000";
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(240, 20);
            this.txtNascimento.TabIndex = 12;
            this.txtNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(508, 200);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(240, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(675, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 60;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 59;
            this.button1.Text = "&Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 200);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 57;
            this.label14.Text = "E-mail";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(419, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "CEP";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(508, 123);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(240, 20);
            this.txtComplemento.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Complemento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "CPF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 51;
            this.label9.Text = "Perfil de Acesso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 50;
            this.label8.Text = "Admissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Telefone";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(155, 148);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(240, 20);
            this.txtCidade.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Cidade";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(155, 122);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(240, 20);
            this.txtBairro.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Bairro";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(155, 96);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(240, 20);
            this.txtEndereco.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 70);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(240, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Nome";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Enabled = false;
            this.txtMatricula.Location = new System.Drawing.Point(155, 44);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(240, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "Matrícula";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - INATIVO",
            "1 - ATIVO"});
            this.comboBox1.Location = new System.Drawing.Point(508, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Selecione o Status";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Status";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(508, 229);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(240, 20);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(417, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 15);
            this.label16.TabIndex = 70;
            this.label16.Text = "Demissão";
            // 
            // estadosBindingSource1
            // 
            this.estadosBindingSource1.DataSource = typeof(ControlSystem.estados);
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 348);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmNewEmployee";
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource estadosBindingSource1;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.MaskedTextBox txtNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label16;

    }
}