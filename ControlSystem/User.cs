using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    public class User
    {
        

        public static string login { get; set; }
        public static string password { get; set; }
        static controlsystemEntities db;
        

        public User(string usuario, string senha) {
            login = usuario;
            password = senha;
        }

        public User() {

        }

        public static Boolean logar(string user, string senha){

            db = new controlsystemEntities();
            string perfil = "";
            
            //string password = (from u in db.usuario
            //                  where u.login == user
            //                  select u.password).First();

            usuario logando = (from u in db.usuario
                              where u.login == user
                              select u).First();

            
            logando.lastLogin = DateTime.Now;
            db.SaveChanges();
            
            
            byte[] data = Convert.FromBase64String(logando.password);
            string decodedString = Encoding.UTF8.GetString(data);

            if (decodedString != senha)
            {
                throw new ApplicationException("Usuário ou senha inválidos!");
            }

            switch(logando.perfil){
                case 0:
                    perfil = "ADMINISTRAÇÃO";
                    break;
                case 1:
                    perfil = "BALCÃO";
                    break;
                case 2:
                    perfil = "GERENTE";
                    break;
            }

            LogInfo.userID = user;
            LogInfo.perfil = perfil;

            return true;
        }

        public static Boolean checkUniqUser(string login) {

            db = new controlsystemEntities();

            int countUser = (from u in db.usuario
                             where u.login == login
                             select u).Count();

            if (countUser > 0)
                throw new ApplicationException("Usuário já existe!");

            return true;
        }
        
    }
}
