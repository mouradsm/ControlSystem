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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainContainer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.stHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDoEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itensEmEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeFornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoLoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsuario,
            this.stHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // stUsuario
            // 
            this.stUsuario.Name = "stUsuario";
            this.stUsuario.Size = new System.Drawing.Size(0, 19);
            this.stUsuario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // stHora
            // 
            this.stHora.Margin = new System.Windows.Forms.Padding(350, 3, 0, 2);
            this.stHora.Name = "stHora";
            this.stHora.Size = new System.Drawing.Size(44, 19);
            this.stHora.Text = "15:00";
            this.stHora.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.compraToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.funcionáriosToolStripMenuItem1,
            this.janelaToolStripMenuItem,
            this.produtoLoteToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
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
            this.novoFuncionárioToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.gerenciarToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.funcionáriosToolStripMenuItem.Text = "&Cliente";
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.novoFuncionárioToolStripMenuItem.Text = "Cadastra&r";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // gerenciarToolStripMenuItem
            // 
            this.gerenciarToolStripMenuItem.Name = "gerenciarToolStripMenuItem";
            this.gerenciarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.gerenciarToolStripMenuItem.Text = "Gerenciar";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCompraToolStripMenuItem,
            this.gerenciarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem,
            this.cadastrarVendaToolStripMenuItem});
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(184, 23);
            this.compraToolStripMenuItem.Text = "Compra/Venda/Dovolução";
            // 
            // cadastroDeCompraToolStripMenuItem
            // 
            this.cadastroDeCompraToolStripMenuItem.Name = "cadastroDeCompraToolStripMenuItem";
            this.cadastroDeCompraToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.cadastroDeCompraToolStripMenuItem.Text = "Cadastrar Compra";
            this.cadastroDeCompraToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeCompraToolStripMenuItem_Click);
            // 
            // gerenciarToolStripMenuItem1
            // 
            this.gerenciarToolStripMenuItem1.Name = "gerenciarToolStripMenuItem1";
            this.gerenciarToolStripMenuItem1.Size = new System.Drawing.Size(205, 24);
            this.gerenciarToolStripMenuItem1.Text = "Gerenciar Compra";
            this.gerenciarToolStripMenuItem1.Click += new System.EventHandler(this.gerenciarToolStripMenuItem1_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar Devolução";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.reportarDevoluçãoToolStripMenuItem_Click);
            // 
            // cadastrarVendaToolStripMenuItem
            // 
            this.cadastrarVendaToolStripMenuItem.Name = "cadastrarVendaToolStripMenuItem";
            this.cadastrarVendaToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.cadastrarVendaToolStripMenuItem.Text = "Cadastrar Venda";
            this.cadastrarVendaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarVendaToolStripMenuItem_Click);
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
            this.cadastroDoEstoqueToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.cadastroDoEstoqueToolStripMenuItem.Text = "Cadast&rar";
            this.cadastroDoEstoqueToolStripMenuItem.Click += new System.EventHandler(this.cadastroDoEstoqueToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // itensEmEstoqueToolStripMenuItem
            // 
            this.itensEmEstoqueToolStripMenuItem.Name = "itensEmEstoqueToolStripMenuItem";
            this.itensEmEstoqueToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.itensEmEstoqueToolStripMenuItem.Text = "Itens em Estoque";
            this.itensEmEstoqueToolStripMenuItem.Click += new System.EventHandler(this.itensEmEstoqueToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeFornecedorToolStripMenuItem});
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
            // funcionáriosToolStripMenuItem1
            // 
            this.funcionáriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem1,
            this.gerenciarFuncionáriosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(92, 23);
            this.funcionáriosToolStripMenuItem1.Text = "&Funcionário";
            // 
            // novoFuncionárioToolStripMenuItem1
            // 
            this.novoFuncionárioToolStripMenuItem1.Name = "novoFuncionárioToolStripMenuItem1";
            this.novoFuncionárioToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.novoFuncionárioToolStripMenuItem1.Text = "Cadastra&r Funcionário";
            this.novoFuncionárioToolStripMenuItem1.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem1_Click);
            // 
            // gerenciarFuncionáriosToolStripMenuItem
            // 
            this.gerenciarFuncionáriosToolStripMenuItem.Name = "gerenciarFuncionáriosToolStripMenuItem";
            this.gerenciarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.gerenciarFuncionáriosToolStripMenuItem.Text = "Gerenciar Funcionário";
            this.gerenciarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarFuncionáriosToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.janelaToolStripMenuItem.Text = "&Janela";
            // 
            // produtoLoteToolStripMenuItem
            // 
            this.produtoLoteToolStripMenuItem.Name = "produtoLoteToolStripMenuItem";
            this.produtoLoteToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.produtoLoteToolStripMenuItem.Text = "Produto/Lote";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // mainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 384);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.ToolStripMenuItem gerenciarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itensEmEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoLoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel stHora;
    }
}