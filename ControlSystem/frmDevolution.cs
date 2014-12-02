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
    public partial class frmDevolution : Form
    {
        controlsystemEntities db;

        public frmDevolution()
        {
            InitializeComponent();
        }

        private void frmDevolution_Load(object sender, EventArgs e)
        {
            controlsystemEntities db = new controlsystemEntities();

            var produtos = (from l in db.lote
                            join p in db.produto on l.produto_id equals p.id
                            select new Produtos() { id_produto = p.id, id_lote = l.id, identificador = l.identificador, descricao = p.desc }).ToList();

            cboProdutos.DataSource = produtos.ToList(); ;
            cboProdutos.DisplayMember = "fullName";
            cboProdutos.ValueMember = "id_lote";

            cboNotaFiscal.DataSource = db.venda.ToList();
            cboNotaFiscal.DisplayMember = "notaFiscal";
            cboNotaFiscal.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                db = new controlsystemEntities();
                int codigoProduto = Convert.ToInt32(cboProdutos.SelectedValue.ToString());

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[0].Text == codigoProduto.ToString())
                    {
                        item.SubItems[4].Text = (Int32.Parse(txtQuantidade.Text) + Int32.Parse(item.SubItems[4].Text)).ToString();
                        return;
                    }
                }

                var lote = (from l in db.lote
                            where l.id == codigoProduto
                            select l).First();

                var itemToInsert = new ListViewItem(new[] { codigoProduto.ToString(),
                                                            lote.produto.desc.ToString(),
                                                            cboNotaFiscal.SelectedText,
                                                            lote.identificador,
                                                            txtQuantidade.Text,
                                                            lote.produto.valorUnitario.ToString(),
                (Convert.ToInt32(txtQuantidade.Text) * lote.produto.valorUnitario).ToString()});

                listView1.Items.Add(itemToInsert);

                int total = 0;

                foreach (ListViewItem item in listView1.Items)
                {
                    total += Convert.ToInt32(item.SubItems[6].Text);
                }

                txtTotal.Text = total.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnExluirTodos_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txtTotal.Text);

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                total -= Convert.ToInt32(item.SubItems[5].Text);
                txtTotal.Text = total.ToString();
                item.Remove();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Form.ClearForm(this);
        }
    }
}
