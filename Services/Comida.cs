using AnimalesYSusSsonidos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesYSusSsonidos.Services
{
    public class Comida
    {
        public List<IObservador> comida = new List<IObservador>();

        public void AgregarAnm(IObservador ob)
        {
            comida.Add(ob);
        }

        public void EliminarAnm(IObservador ob)
        {
            comida.Remove(ob);
        }

        public void Modificar(string olor)
        {
            foreach (var food in comida)
            {
                food.Update(olor);
            }
        }

        public void ComidaOperacion(string olor)
        {
            Modificar(olor);
        }
    }
}
