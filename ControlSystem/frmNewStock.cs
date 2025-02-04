﻿using System;
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
        
        controlsystemEntities db;

        public frmNewStock()
        {
            InitializeComponent();
        }

        private void frmNewStock_Load(object sender, EventArgs e)
        {
            controlsystemEntities db = new controlsystemEntities();

            var produtos = (from l in db.lote
                           join p in db.produto on l.produto_id equals p.id
                           select new Produtos() { id_produto = p.id, id_lote = l.id,identificador = l.identificador, descricao = p.desc}).ToList();

            comboBox1.DataSource = produtos.ToList(); ;
            comboBox1.DisplayMember = "fullName";
            comboBox1.ValueMember = "id_lote";
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
                db = new controlsystemEntities();
                estoque novoEstoque = new estoque();

                //INSERIR LOTE    
                novoEstoque.lote_id = Convert.ToInt32(comboBox1.SelectedValue);

                novoEstoque.codLoja         = 1;
                novoEstoque.estoqueMaximo   = Int32.Parse(txtEstoqueMaximo.Text);
                novoEstoque.estoqueMinimo   = Int32.Parse(txtEstoqueMinimo.Text);
                novoEstoque.quantidade      = Int32.Parse(txtQuantidade.Text);
                novoEstoque.status = 1;
                                               
                db.estoque.Add(novoEstoque);
                db.SaveChanges();

                Form.ClearForm(this);

                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
