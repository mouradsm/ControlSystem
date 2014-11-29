namespace ControlSystem
{
    partial class frmNewProduct
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtFabricacao = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(656, 304);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(562, 304);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstoqueMaximo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtEstoqueMinimo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 91);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Estoque";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(555, 39);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(101, 20);
            this.txtEstoqueMaximo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(452, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Estoque Máximo";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(335, 39);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(101, 20);
            this.txtEstoqueMinimo.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estoque Mínimo";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(109, 39);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(101, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantidade";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(141, 152);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(101, 20);
            this.txtValorUnitario.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Valor Unitário";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "0 - INATIVO",
            "1 - ATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(562, 107);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(106, 21);
            this.cboStatus.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Status";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(393, 107);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(101, 20);
            this.txtLote.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lote";
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(141, 107);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(179, 21);
            this.cboFornecedor.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fornecedor";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(394, 63);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(274, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(141, 63);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(179, 20);
            this.txtProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(141, 23);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(179, 20);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(326, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Validade";
            // 
            // txtValidade
            // 
            this.txtValidade.Location = new System.Drawing.Point(394, 155);
            this.txtValidade.Mask = "00/00/0000";
            this.txtValidade.Name = "txtValidade";
            this.txtValidade.Size = new System.Drawing.Size(100, 20);
            this.txtValidade.TabIndex = 18;
            this.txtValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtFabricacao
            // 
            this.txtFabricacao.Location = new System.Drawing.Point(568, 155);
            this.txtFabricacao.Mask = "00/00/0000";
            this.txtFabricacao.Name = "txtFabricacao";
            this.txtFabricacao.Size = new System.Drawing.Size(100, 20);
            this.txtFabricacao.TabIndex = 20;
            this.txtFabricacao.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(500, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fabricação";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // frmNewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 358);
            this.Controls.Add(this.txtFabricacao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValidade);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtValorUnitario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFornecedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label1);
            this.Name = "frmNewProduct";
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.frmNewProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtValidade;
        private System.Windows.Forms.MaskedTextBox txtFabricacao;
        private System.Windows.Forms.Label label12;
    }
}