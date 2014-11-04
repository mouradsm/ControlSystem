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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.funcionáriosToolStripMenuItem1,
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
            this.novoFuncionárioToolStripMenuItem1});
            this.funcionáriosToolStripMenuItem1.Name = "funcionáriosToolStripMenuItem1";
            this.funcionáriosToolStripMenuItem1.Size = new System.Drawing.Size(98, 23);
            this.funcionáriosToolStripMenuItem1.Text = "&Funcionários";
            // 
            // novoFuncionárioToolStripMenuItem1
            // 
            this.novoFuncionárioToolStripMenuItem1.Name = "novoFuncionárioToolStripMenuItem1";
            this.novoFuncionárioToolStripMenuItem1.Size = new System.Drawing.Size(212, 24);
            this.novoFuncionárioToolStripMenuItem1.Text = "Cadastra&r Funcionário";
            this.novoFuncionárioToolStripMenuItem1.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem1_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.janelaToolStripMenuItem.Text = "&Janela";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 336);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stUsuario
            // 
            this.stUsuario.Name = "stUsuario";
            this.stUsuario.Size = new System.Drawing.Size(0, 17);
            this.stUsuario.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // mainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 358);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainContainer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainContainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainContainer_FormClosing);
            this.Load += new System.EventHandler(this.mainContainer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}