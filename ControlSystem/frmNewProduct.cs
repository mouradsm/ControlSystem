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
            try
            {
                db = new controlsystemEntities();
                produto novoProduto = new produto();
                novoProduto.desc = txtProduto.Text;
                novoProduto.valorUnitario = float.Parse(txtValorUnitario.Text);
                novoProduto.status = cboStatus.SelectedIndex;

                lote novoLote = new lote();
                novoLote.produto = novoProduto;
                novoLote.identificador = txtLote.Text;

                novoLote.dataValidade = DateTime.Parse(txtValidade.Text);
                novoLote.dataFabricacao = DateTime.Parse(txtFabricacao.Text);

                estoque novoEstoque = new estoque();

                novoEstoque.quantidade = Int32.Parse(txtQuantidade.Text);

                novoEstoque.estoqueMaximo = Int32.Parse(txtEstoqueMaximo.Text);
                novoEstoque.estoqueMinimo = Int32.Parse(txtEstoqueMinimo.Text);

                novoEstoque.lote = novoLote;
                
                db.SaveChanges();

                MessageBox.Show("Produto criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
