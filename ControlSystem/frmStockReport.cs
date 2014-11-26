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
    public partial class frmStockReport : Form
    {
        controlsystemEntities db;

        public frmStockReport()
        {
            InitializeComponent();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            var produtos = (from p in db.produto
                            select p).ToList();

            foreach (var produto in produtos)
            {
                var itemToInsert = new ListViewItem(new[] { produto.desc + " - " + produto.id.ToString() });
                listView1.Items.Add(itemToInsert);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string[] produtoArray = listView1.SelectedItems[0].Text.Split();

                int id = Int32.Parse(produtoArray[5]);

                var produtos = (from l in db.lote
                                where l.produto_id == id
                                select l).ToList();

                listView2.Items.Clear();

                if (produtos.Count == 0)
                {
                    MessageBox.Show("Sem lote cadastrado para este produto");
                    return;
                }

                foreach (var produto in produtos)
                {
                    if (produto.estoque.Count == 0)
                    {
                        MessageBox.Show("Item não cadastrado em estoque!");
                        return;
                    }

                    var itemToInsert = new ListViewItem(new[] {produto.identificador,produto.produto.desc, "01",
                        produto.estoque.First().quantidade.ToString() != "" ? produto.estoque.First().quantidade.ToString() : "0"  , produto.produto.valorUnitario.ToString() });

                    
                    listView2.Items.Add(itemToInsert);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Enabled = !((CheckBox)sender).Checked;

            listView2.Items.Clear();

            if (!checkBox1.Checked)
                return;

            var produtos = (from l in db.lote
                            select l).ToList();

            

            if (produtos.Count == 0)
            {
                MessageBox.Show("Sem produtos cadastrados");
                return;
            }

            foreach (var produto in produtos)
            {
                if (produto.estoque.Count == 0)
                {
                    MessageBox.Show("Item: " + produto.produto.desc + " não cadastrado em estoque!");
                    continue;
                }

                var itemToInsert = new ListViewItem(new[] {produto.identificador,produto.produto.desc, "01",
                        produto.estoque.First().quantidade.ToString() != "" ? produto.estoque.First().quantidade.ToString() : "0"  , produto.produto.valorUnitario.ToString() });


                listView2.Items.Add(itemToInsert);
            }
        }
    }
}
