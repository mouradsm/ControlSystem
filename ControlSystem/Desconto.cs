using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem
{
    class Desconto
    {
        static controlsystemEntities db;

        public static int getDesconto(cliente cliente) {

            int desconto = 0;

            db = new controlsystemEntities();

            DateTime hoje = DateTime.Now;

            TimeSpan diff = hoje - cliente.dateDeCadastramento;

            if (diff.Days > 180)
                desconto = 10;

            if (diff.Days > 365)
                desconto = 20;


            return desconto;
        }
    }
}
