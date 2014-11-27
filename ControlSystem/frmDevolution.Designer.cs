namespace ControlSystem
{
    partial class frmDevolution
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
            this.cboFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNotaFiscal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.Location = new System.Drawing.Point(106, 42);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(210, 21);
            this.cboFuncionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota Fiscal de Venda";
            // 
            // cboNotaFiscal
            // 
            this.cboNotaFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNotaFiscal.FormattingEnabled = true;
            this.cboNotaFiscal.Location = new System.Drawing.Point(472, 42);
            this.cboNotaFiscal.Name = "cboNotaFiscal";
            this.cboNotaFiscal.Size = new System.Drawing.Size(210, 21);
            this.cboNotaFiscal.TabIndex = 3;
            // 
            // frmDevolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 358);
            this.Controls.Add(this.cboNotaFiscal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "frmDevolution";
            this.Text = "Devolução";
            this.Load += new System.EventHandler(this.frmDevolution_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNotaFiscal;
    }
}