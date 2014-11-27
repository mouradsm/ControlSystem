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

        //BTN SALVAR
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    MessageBox.Show("a!");
            //}
        }
    }
}
