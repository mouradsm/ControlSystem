using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    class User
    {
        public static string login { get; set; }
        public static string password { get; set; }
        static cscEntities db;
        

        public User(string usuario, string senha) {
            login = usuario;
            password = senha;
        }

        public User() {

        }

        public static Boolean logar(string usuario, string senha){
           
           db = new cscEntities();

            string password = (from u in db.usuario
                              where u.login == usuario
                              select u.password).First();

            
            byte[] data = Convert.FromBase64String(password);
            string decodedString = Encoding.UTF8.GetString(data);

            if (decodedString != senha)
            {
                throw new ApplicationException("Usuário ou senha inválidos!");
            }
                
            return true;
        }

        public static Boolean checkUniqUser(string login) {

            db = new cscEntities();

            int countUser = (from u in db.usuario
                             where u.login == login
                             select u).Count();

            if (countUser > 0)
                throw new ApplicationException("Usuário já existe!");

            return true;
        }
        
    }
}
