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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                User.logar(txtUser.Text, txtPass.Text);
                LogInfo.userID = txtUser.Text;
                this.Hide();
                

                mainContainer container = new mainContainer();
                container.Show();


            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                
            }

            
        }

        private void lblNovoUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewUser frmNewUser = new frmNewUser();
            this.Hide();
            frmNewUser.Show();

        }
    }
}
