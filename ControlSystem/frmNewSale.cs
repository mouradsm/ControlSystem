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
    public partial class frmNewSale : Form
    {
        controlsystemEntities db;
        public frmNewSale()
        {
            InitializeComponent();
        }

        private void frmNewSale_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            cboFuncionario.DataSource = db.funcionario.ToList();
            cboFuncionario.DisplayMember = "nome";
            cboFuncionario.ValueMember = "id";

            cboCliente.DataSource = db.cliente.ToList();
            cboCliente.DisplayMember = "nome";
            cboCliente.ValueMember = "id";

            var produtos = (from l in db.lote
                            join p in db.produto on l.produto_id equals p.id
                            join s in db.estoque on l.id equals s.lote_id
                            where s.quantidade > 0
                            select new Produtos() { id_produto = p.id, id_lote = l.id, identificador = l.identificador, descricao = p.desc }).ToList();

            cboProdutos.DataSource = produtos.ToList(); ;
            cboProdutos.DisplayMember = "fullName";
            cboProdutos.ValueMember = "id_lote";


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //BTN ADD
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDesconto.Text == string.Empty)
                {
                    if (cboCliente.Items.Count > 0)
                    {

                        int id = Int32.Parse(cboCliente.SelectedValue.ToString());

                        txtDesconto.Text = Desconto.getDesconto((from c in db.cliente where c.id == id select c).First()).ToString();
                    }
                }

                db = new controlsystemEntities();
                int codigoProduto = Convert.ToInt32(cboProdutos.SelectedValue.ToString());

                //VERIFICA SE O ITEM JÁ EXISTE E SE POSITIVO SOMA A QUANTIDADE
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[0].Text == codigoProduto.ToString()) {
                        item.SubItems[2].Text = (Int32.Parse(txtQuantidade.Text) + Int32.Parse(item.SubItems[2].Text)).ToString() ;
                        return;
                    }
                }

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            var trans = db.Database.BeginTransaction();
            try
            {
                venda novaVenda = new venda();

                novaVenda.cliente_id = Int32.Parse(cboCliente.SelectedValue.ToString());
                novaVenda.dataDaVenda = DateTime.Parse(txtDataVenda.Text);
                novaVenda.funcionario_id = Int32.Parse(cboFuncionario.SelectedValue.ToString());
                novaVenda.notaFiscal = Int32.Parse(txtNotaFiscal.Text);
                novaVenda.valorTotal = float.Parse(txtTotal.Text);
                novaVenda.valorTotalComDesconto = float.Parse(txtTotalComDesconto.Text);

                db.venda.Add(novaVenda);

                foreach (ListViewItem item in listView1.Items)
                {
                    venda_produto novaVendaProduto = new venda_produto();

                    novaVendaProduto.venda = novaVenda;
                    novaVendaProduto.lote_id = Convert.ToInt32(item.SubItems[0].Text);
                    novaVendaProduto.quantidade = Convert.ToInt32(item.SubItems[2].Text);
                    novaVendaProduto.valorUnitario = Convert.ToInt32(item.SubItems[4].Text);

                    estoque estoque = (from es in db.estoque
                                      where es.lote_id == novaVendaProduto.lote_id
                                      select es).First();

                    estoque.quantidade -= novaVendaProduto.quantidade;

                    db.venda_produto.Add(novaVendaProduto);

                    db.SaveChanges();                
                }

                trans.Commit();

                Form.ClearForm(this);
                listView1.Items.Clear();
                MessageBox.Show("Venda Efetuada!");

            }
            catch (Exception ex)
            {
                trans.Rollback();                
                MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Form.ClearForm(this);
        }

        private void btnExcluirTodos_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            txtTotal.Clear();
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

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            double percent = (float.Parse(txtDesconto.Text) / 100.0);
            double valor = Double.Parse(txtTotal.Text);

            double totalComDesconto = valor - (valor * percent);

            txtTotalComDesconto.Text = totalComDesconto.ToString();
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

        private void cboFuncionario_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}
