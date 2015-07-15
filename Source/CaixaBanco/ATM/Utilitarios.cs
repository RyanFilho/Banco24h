using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Banco
{   
    public class Utilitarios {    

        internal static int ValorDasNotas(Cedulas notas)
        {
            int total;
            total = notas[Notas.Cem] * 100;
            total = notas[Notas.Cinquenta] * 50;
            total = notas[Notas.Vinte] * 20;
            total = notas[Notas.Dez] * 10;
            total = notas[Notas.Cinco] * 5;
            total = notas[Notas.Dois] * 2;
            return total;
        }

        internal static Cedulas ValorDoDinheiro(int dinheiro)
        {
            var cedulas = new Cedulas();           

            cedulas.Add(Notas.Cem, dinheiro / 100);
            dinheiro -= (int)Notas.Cem * 100;
            cedulas.Add(Notas.Cinquenta, dinheiro / 100);
            dinheiro -= (int)Notas.Cinquenta * 50;
            cedulas.Add(Notas.Vinte, dinheiro / 100);
            dinheiro -= (int)Notas.Vinte * 20;
            cedulas.Add(Notas.Dez, dinheiro / 100);
            dinheiro -= (int)Notas.Dez * 10;
            cedulas.Add(Notas.Cinco, dinheiro / 100);
            dinheiro -= (int)Notas.Cinco * 5;
            cedulas.Add(Notas.Dois, dinheiro / 100); 

            return cedulas;
        }

    }
    
}