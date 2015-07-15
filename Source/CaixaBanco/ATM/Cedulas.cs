using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cedulas : Dictionary<Notas, int>
    {
        public Cedulas()
        {
            this.Add(Notas.Cem, 0);
            this.Add(Notas.Cinquenta, 0);
            this.Add(Notas.Vinte, 0);
            this.Add(Notas.Dez, 0);
            this.Add(Notas.Cinco, 0);
            this.Add(Notas.Dois, 0);
        }
    }
}
