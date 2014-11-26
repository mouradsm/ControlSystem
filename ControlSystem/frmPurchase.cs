using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public partial class frmPurchase : Form
    {
        controlsystemEntities db;
        public frmPurchase()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            var produtos = (from l in db.lote
                            join p in db.produto on l.produto_id equals p.id
                            select new Produtos() { id_produto = p.id, id_lote = l.id, identificador = l.identificador, descricao = p.desc }).ToList();

            cboProdutos.DataSource = produtos.ToList(); ;
            cboProdutos.DisplayMember = "fullName";
            cboProdutos.ValueMember = "id_lote";

            cboFornecedor.DataSource = db.fornecedor.ToList();
            cboFornecedor.DisplayMember = "razaoSocial";
            cboFornecedor.ValueMember = "id";


        }

        private void button3_Click(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                db = new controlsystemEntities();
                int codigoProduto = Convert.ToInt32(cboProdutos.SelectedValue.ToString());


                var lote = (from l in db.lote
                            where l.id == codigoProduto
                            select l).First();

                var itemToInsert = new ListViewItem(new[] { codigoProduto.ToString(), "01", txtQuantidade.Text,lote.produto.desc.ToString(),lote.produto.valorUnitario.ToString(),
                (Convert.ToInt32(txtQuantidade.Text) * lote.produto.valorUnitario).ToString()  });

                listView1.Items.Add(itemToInsert);

                int total = 0;

                foreach (ListViewItem item in listView1.Items)
                {
                    total += Convert.ToInt32(item.SubItems[5].Text);

                }

                txtTotal.Text = total.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ClearForm(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(txtTotal.Text);

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                total -= Convert.ToInt32(item.SubItems[5].Text);
                txtTotal.Text = total.ToString();
                item.Remove();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;

            try
            {
                int lote_id = Convert.ToInt32(cboProdutos.SelectedValue.ToString());

                db = new controlsystemEntities();
                compra novaCompra = new compra();

                novaCompra.dataDeEntrega = DateTime.Parse(txtEntrega.Text);
                novaCompra.fornecedor_id = Convert.ToInt32(cboFornecedor.SelectedValue.ToString());
                novaCompra.valorTotal = float.Parse(txtTotal.Text);

                db.compra.Add(novaCompra);


                foreach (ListViewItem item in listView1.Items)
                {
                    compra_produto novaCompraProduto = new compra_produto();

                    novaCompraProduto.compra = novaCompra;
                    novaCompraProduto.lote_id = 1;
                    novaCompraProduto.valorUnitario = Convert.ToInt32(item.SubItems[5].Text);
                    novaCompraProduto.quantidade = Convert.ToInt32(item.SubItems[4].Text);

                    db.compra_produto.Add(novaCompraProduto);
                }

                db.SaveChanges();

                Form.ClearForm(this);
                listView1.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtQuantidade.Text.Trim() == "")
            {
                errorProvider1.SetError(txtQuantidade, "Quantidade é obrigatório");
                e.Cancel = true;
                return;
            }
            else if (Regex.IsMatch(txtQuantidade.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtQuantidade, "Somente números são permitidos");
                e.Cancel = true;
                return;
            }

            // Name is Valid
            errorProvider1.SetError(txtQuantidade, "");
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
