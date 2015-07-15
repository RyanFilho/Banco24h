using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Saque
    {        
        public int valorSacado { get; private set; }         

        public Saque()
        {                
        }         
        public Cedulas sacar(int saque)
        {

            var cedulaSacadas = new Cedulas();            
            valorSacado = saque;
            
            if((saque % 2 == 0 || saque % 5 == 0) && saque > 0)
            {
                cedulaSacadas[Notas.Cem] = saque / 100;
                saque -= cedulaSacadas[Notas.Cem] * 100;
                cedulaSacadas[Notas.Cinquenta] = saque / 50;
                saque -= cedulaSacadas[Notas.Cinquenta] * 50;
                cedulaSacadas[Notas.Vinte] = saque / 20;
                saque -= cedulaSacadas[Notas.Vinte] * 20;
                cedulaSacadas[Notas.Dez] = saque / 10;
                saque -= cedulaSacadas[Notas.Dez] * 10;
                cedulaSacadas[Notas.Cinco] = saque / 5;
                saque -= cedulaSacadas[Notas.Cinco] * 5;
                cedulaSacadas[Notas.Dois] = saque / 2;         
                
            }else {
                throw new ArgumentException("Valor Invalido Para Saque");               
            }
            return cedulaSacadas;
        }       


    }
}
