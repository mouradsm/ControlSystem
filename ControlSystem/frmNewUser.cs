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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            
        }

        private void frmNewUser_Deactivate(object sender, EventArgs e)
        {


        }

        private void frmNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtReSenha.Text)
            {
                try
                {
                    User.checkUniqUser(txtLogin.Text);

                    controlsystemEntities db = new controlsystemEntities();
                    usuario novoUsuario = new usuario() { login = txtLogin.Text,
                                                          password    = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSenha.Text)),
                                                          funcionario_id = Convert.ToInt32(txtMatricula.Text)};
                    
                    db.usuario.Add(novoUsuario);
                    db.SaveChanges();

                    this.Close();
                    this.Dispose();

                }
                catch (Exception ex)
                {
                    lblMsg.Text = ex.Message;
                }

            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
