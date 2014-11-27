namespace ControlSystem
{
    partial class mainContainer
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDoEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensEmEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportarDevoluçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // stUsuario
            // 
            this.stUsuario.Name = "stUsuario";
            this.stUsuario.Size = new System.Drawing.Size(0, 17);
            this.stUsuario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.vendaDevoluçãoToolStripMenuItem,
            this.funcionáriosToolStripMenuItem1,
            this.fornecedorToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.janelaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelaToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.funcionáriosToolStripMenuItem.Text = "&Clientes";
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.novoFuncionárioToolStripMenuItem.Text = "Cadastra&r Cliente";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem1,
            this.gerenciarFuncionáriosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(98, 23);
            this.funcionáriosToolStripMenuItem1.Text = "&Funcionários";
            // 
            // novoFuncionárioToolStripMenuItem1
            // 
            this.novoFuncionárioToolStripMenuItem1.Name = "novoFuncionárioToolStripMenuItem1";
            this.novoFuncionárioToolStripMenuItem1.Size = new System.Drawing.Size(217, 24);
            this.novoFuncionárioToolStripMenuItem1.Text = "Cadastra&r Funcionário";
            this.novoFuncionárioToolStripMenuItem1.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem1_Click);
            // 
            // gerenciarFuncionáriosToolStripMenuItem
            // 
            this.gerenciarFuncionáriosToolStripMenuItem.Name = "gerenciarFuncionáriosToolStripMenuItem";
            this.gerenciarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.gerenciarFuncionáriosToolStripMenuItem.Text = "Gerenciar Funcionários";
            this.gerenciarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFuncionáriosToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFornecedorToolStripMenuItem,
            this.cadastroDeCompraToolStripMenuItem});
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.fornecedorToolStripMenuItem.Text = "For&necedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // cadastroDeFornecedorToolStripMenuItem
            // 
            this.cadastroDeFornecedorToolStripMenuItem.Name = "cadastroDeFornecedorToolStripMenuItem";
            this.cadastroDeFornecedorToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cadastroDeFornecedorToolStripMenuItem.Text = "Cadastro Fornecedor";
            this.cadastroDeFornecedorToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeFornecedorToolStripMenuItem_Click);
            // 
            // cadastroDeCompraToolStripMenuItem
            // 
            this.cadastroDeCompraToolStripMenuItem.Name = "cadastroDeCompraToolStripMenuItem";
            this.cadastroDeCompraToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cadastroDeCompraToolStripMenuItem.Text = "Cadastro de Compra";
            this.cadastroDeCompraToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCompraToolStripMenuItem_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDoEstoqueToolStripMenuItem,
            this.cadastrarProdutoToolStripMenuItem,
            this.itensEmEstoqueToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.estoqueToolStripMenuItem.Text = "&Estoque";
            // 
            // cadastroDoEstoqueToolStripMenuItem
            // 
            this.cadastroDoEstoqueToolStripMenuItem.Name = "cadastroDoEstoqueToolStripMenuItem";
            this.cadastroDoEstoqueToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cadastroDoEstoqueToolStripMenuItem.Text = "Cadast&ro do Estoque";
            this.cadastroDoEstoqueToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoEstoqueToolStripMenuItem_Click);
            // 
            // itensEmEstoqueToolStripMenuItem
            // 
            this.itensEmEstoqueToolStripMenuItem.Name = "itensEmEstoqueToolStripMenuItem";
            this.itensEmEstoqueToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.itensEmEstoqueToolStripMenuItem.Text = "Itens em Estoque";
            this.itensEmEstoqueToolStripMenuItem.Click += new System.EventHandler(this.itensEmEstoqueToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.janelaToolStripMenuItem.Text = "&Janela";
            // 
            // vendaDevoluçãoToolStripMenuItem
            // 
            this.vendaDevoluçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVendaToolStripMenuItem,
            this.reportarDevoluçãoToolStripMenuItem});
            this.vendaDevoluçãoToolStripMenuItem.Name = "vendaDevoluçãoToolStripMenuItem";
            this.vendaDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.vendaDevoluçãoToolStripMenuItem.Text = "Venda/Devolução";
            // 
            // cadastrarVendaToolStripMenuItem
            // 
            this.cadastrarVendaToolStripMenuItem.Name = "cadastrarVendaToolStripMenuItem";
            this.cadastrarVendaToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.cadastrarVendaToolStripMenuItem.Text = "Cadastrar Venda";
            this.cadastrarVendaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVendaToolStripMenuItem_Click);
            // 
            // reportarDevoluçãoToolStripMenuItem
            // 
            this.reportarDevoluçãoToolStripMenuItem.Name = "reportarDevoluçãoToolStripMenuItem";
            this.reportarDevoluçãoToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.reportarDevoluçãoToolStripMenuItem.Text = "Reportar Devolução";
            this.reportarDevoluçãoToolStripMenuItem.Click += new System.EventHandler(this.reportarDevoluçãoToolStripMenuItem_Click);
            // 
            // mainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control System for Confectionery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainContainer_FormClosing);
            this.Load += new System.EventHandler(this.mainContainer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stUsuario;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDoEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeFornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensEmEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaDevoluçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportarDevoluçãoToolStripMenuItem;
    }
}