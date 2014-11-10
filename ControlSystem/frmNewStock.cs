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
    public partial class frmNewStock : Form
    {
        cscEntities db;

        public frmNewStock()
        {
            InitializeComponent();
        }

        private void frmNewStock_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                db = new cscEntities();
                estoque novoEstoque = new estoque();

                novoEstoque.codProduto      = Int32.Parse(txtCodigoProduto.Text);
                novoEstoque.codLoja         = Int32.Parse(txtCodigoLoja.Text);
                novoEstoque.estoqueMaximo   = Int32.Parse(txtEstoqueMaximo.Text);
                novoEstoque.estoqueMinimo   = Int32.Parse(txtEstoqueMinimo.Text);
                novoEstoque.precoUnitVenda  = Int32.Parse(txtPrecoUnitario.Text);
                novoEstoque.quantidade      = Int32.Parse(txtQuantidade.Text);
                novoEstoque.status          = cboStatus.SelectedText;
                novoEstoque.tipoProduto     = txtTipoProduto.Text;

                db.estoque.Add(novoEstoque);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
