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
    public partial class frmNewBatch : Form
    {
        controlsystemEntities db;

        public frmNewBatch()
        {
            InitializeComponent();
        }

        private void frmNewBatch_Load(object sender, EventArgs e)
        {
            cboProdutos.DataSource = db.produto.ToList(); ;
            cboProdutos.DisplayMember = "desc";
            cboProdutos.ValueMember = "id";
        }
    }
}
