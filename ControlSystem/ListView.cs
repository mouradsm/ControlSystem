using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSystem
{
    public class ListView : System.Windows.Forms.ListView
    {
        public static void reloadListView(System.Windows.Forms.ListView control, Boolean haveLogin)
        {

            controlsystemEntities db = new controlsystemEntities();
            
            control.Items.Clear();

            if (!haveLogin)
            {        

                var funcionarioSemLogin = (from f in db.funcionario
                                           where !(from u in db.usuario
                                                   select u.funcionario_id).Contains(f.id)
                                           select f).ToList();

                foreach (var item in funcionarioSemLogin)
                {
                    var itemToInsert = new ListViewItem(new[] { item.nome, item.cargo, item.email });
                    control.Items.Add(itemToInsert);
                }

            }
            else
            {
                
                var funcionariosComLogin = (from f in db.funcionario
                                            join u in db.usuario
                                            on f.id equals u.funcionario_id into all
                                            from a in all
                                            select a).ToList();



                foreach (var item in funcionariosComLogin)
                {
                    var itemToInsert = new ListViewItem(new[] { item.funcionario.nome, item.funcionario.cargo, item.funcionario.email, item.perfil.ToString(), item.login, item.lastLogin.ToString() });
                    control.Items.Add(itemToInsert);
                }
            }
        }
    }
}
