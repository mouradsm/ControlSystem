namespace ControlSystem
{
    partial class frmNewStock
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
            this.label10 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoLoja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.txtTipoProduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntSalvar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(79, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cboStatus.Location = new System.Drawing.Point(202, 229);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(66, 21);
            this.cboStatus.TabIndex = 17;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(202, 199);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(66, 20);
            this.txtPrecoUnitario.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Preço Unitário";
            // 
            // txtCodigoLoja
            // 
            this.txtCodigoLoja.Location = new System.Drawing.Point(537, 49);
            this.txtCodigoLoja.Name = "txtCodigoLoja";
            this.txtCodigoLoja.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoLoja.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(437, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Código Loja";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(377, 170);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(66, 20);
            this.txtEstoqueMinimo.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estoque Mínimo";
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(202, 169);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(66, 20);
            this.txtEstoqueMaximo.TabIndex = 7;
            // 
            // txtTipoProduto
            // 
            this.txtTipoProduto.Location = new System.Drawing.Point(537, 136);
            this.txtTipoProduto.Name = "txtTipoProduto";
            this.txtTipoProduto.Size = new System.Drawing.Size(153, 20);
            this.txtTipoProduto.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo de Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estoque Máximo";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(202, 139);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(229, 20);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(202, 109);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(229, 20);
            this.txtFornecedor.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(202, 79);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(66, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(615, 232);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bntSalvar
            // 
            this.bntSalvar.Location = new System.Drawing.Point(534, 232);
            this.bntSalvar.Name = "bntSalvar";
            this.bntSalvar.Size = new System.Drawing.Size(75, 23);
            this.bntSalvar.TabIndex = 61;
            this.bntSalvar.Text = "&Salvar";
            this.bntSalvar.UseVisualStyleBackColor = true;
            this.bntSalvar.Click += new System.EventHandler(this.bntSalvar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(202, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // loteBindingSource
            // 
            this.loteBindingSource.DataSource = typeof(ControlSystem.lote);
            // 
            // frmNewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 295);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.bntSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCodigoLoja);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEstoqueMinimo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstoqueMaximo);
            this.Controls.Add(this.txtTipoProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNewStock";
            this.Text = "Cadastro do Estoque";
            this.Load += new System.EventHandler(this.frmNewStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoProduto;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.TextBox txtCodigoLoja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bntSalvar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource loteBindingSource;
    }
}