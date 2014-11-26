using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class frmNewProduct : Form
    {
        controlsystemEntities db;
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private void frmNewProduct_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            cboFornecedor.DataSource = db.fornecedor.ToList();
            cboFornecedor.DisplayMember = "razaoSocial";
            cboFornecedor.ValueMember = "id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
