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

        private void button1_Click(object sender, EventArgs e)
        {

            db = new controlsystemEntities();
            try
            {
                lote novoLote = new lote();
                novoLote.dataFabricacao = DateTime.Parse(txtFabricacao.Text);
                novoLote.dataValidade = DateTime.Parse(txtValidade.Text);
                novoLote.identificador = txtIdentificador.Text;
                novoLote.produto_id = Int32.Parse(cboProdutos.SelectedValue.ToString());

                db.lote.Add(novoLote);

                MessageBox.Show("Lote cadastrado com sucesso!");

                Form.ClearForm(this);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
