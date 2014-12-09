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
    public partial class frmMngEmployees : Form
    {
        controlsystemEntities db;
        bool toInsert;

        public frmMngEmployees()
        {
            InitializeComponent();
        }

        private void frmMngEmployees_Load(object sender, EventArgs e)
        {
            db = new controlsystemEntities();

            var funcionarioSemLogin = (from f in db.funcionario
                                       where !(from u in db.usuario
                                               select u.funcionario_id).Contains(f.id)
                                       select f).ToList();

            foreach (var item in funcionarioSemLogin)
            {
                var itemToInsert = new ListViewItem(new[] { item.nome, item.cargo, item.email });
                listView1.Items.Add(itemToInsert);
            }

            var funcionariosComLogin = (from f in db.funcionario
                                        join u in db.usuario
                                        on f.id equals u.funcionario_id into all
                                        from a in all
                                        select a).ToList();

            foreach (var item in funcionariosComLogin)
            {
                var itemToInsert = new ListViewItem(new[] { item.funcionario.nome, item.funcionario.cargo, item.funcionario.email, item.perfil.ToString(), item.login, item.lastLogin.ToString() });
                listView3.Items.Add(itemToInsert);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            toInsert = true;
            //CARREGA OS DADOS DO LIST PARA OS INPUTS
            var item = listView1.SelectedItems[0].SubItems;
            txtNome.Text = item[0].Text;
            txtEmail.Text = item[2].Text;

            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
            cboPerfil.SelectedIndex = -1;

            //LIMPA O INDICE PARA QUE SEJA POSSÍVEL SELECIONAR NOVAMENTE.   
            listView1.SelectedIndices.Clear();

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0) return;

            toInsert = false;

            //CARREGA OS DADOS DO LIST PARA OS INPUTS
            var item = listView3.SelectedItems[0].SubItems;
            txtNome.Text = item[0].Text;
            txtEmail.Text = item[2].Text;
            txtLogin.Text = item[4].Text;
            cboPerfil.SelectedIndex = Convert.ToInt32(item[3].Text);

            //LIMPA O INDICE PARA QUE SEJA POSSÍVEL SELECIONAR NOVAMENTE.   
            //listView3.SelectedIndices.Clear();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                db = new controlsystemEntities();
                // funcionario novoFuncionario = new funcionario();
                usuario novoUsuario = new usuario();

                string novaSenha = Convert.ToBase64String(Encoding.UTF8.GetBytes(txtSenha.Text));

                //EDITAR
                //                if (listView3.SelectedItems.Count == 1)
                if (!toInsert)
                {

                    funcionario funcionario = (from f in db.funcionario
                                               join u in db.usuario
                                               on f.id equals u.funcionario_id
                                               where u.login == txtLogin.Text
                                               select f).First();

                    usuario user = funcionario.usuario.First();
                    

                    funcionario.nome = txtNome.Text;
                    funcionario.email = txtEmail.Text;
                    user.login = txtLogin.Text;

                    if ((txtSenha.Text != "") && (txtSenha.Text.Length) >= 6 && (novaSenha != user.password))
                        user.password = novaSenha;

                    user.perfil = cboPerfil.SelectedIndex;

                    db.SaveChanges();

                    Form.ClearForm(this);

                    ListView.reloadListView(listView3, true);

                }
                else { 
                    funcionario funcionario = (from f  in db.funcionario
                                                   where f.nome == txtNome.Text
                                                   && f.email == txtEmail.Text
                                                   select f).First();

                    novoUsuario.login = txtLogin.Text;

                    if ((txtSenha.Text == "") || (txtSenha.Text.Length) < 6)
                        throw new ApplicationException("Senha inválida! A senha deve ser de no mímino 6 caractéres");

                    novoUsuario.password = novaSenha;
                    novoUsuario.perfil = cboPerfil.SelectedIndex;
                    novoUsuario.funcionario = funcionario;
                    db.usuario.Add(novoUsuario);
                    db.SaveChanges();

                    ListView.reloadListView(listView1, false);
                    ListView.reloadListView(listView3, true);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um Login!");
                return;
            }

            DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                try
                {

                
                string login = listView3.SelectedItems[0].SubItems[4].ToString();

                var loginToDelete = (from u in db.usuario
                                    where u.login == login
                                    select u).FirstOrDefault();

                db.usuario.Remove(loginToDelete);
                db.SaveChanges();

                MessageBox.Show("Login removido com sucesso");
                ListView.reloadListView(listView3, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }            
        }




    }
}
