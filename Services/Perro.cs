using AnimalesYSusSsonidos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalesYSusSsonidos.Services
{
    public class Perro : IObservador
    {
        public void Update(string olor)
        {
            if (olor == "pollo")
            {
                Console.WriteLine("JUAO JUAO JUAO");
            }
        }
    }
}
