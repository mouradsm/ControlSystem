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
    public partial class frmNewSupplier : Form
    {
        controlsystemEntities db;
        public frmNewSupplier()
        {
            InitializeComponent();
        }

        private void frmNewSupplier_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();
            cboUF.DataSource = db.estados.ToList();
            cboUF.DisplayMember = "sigla";
            cboUF.ValueMember = "sigla";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
