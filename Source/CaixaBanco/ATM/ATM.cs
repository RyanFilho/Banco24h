using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ATM
    {
        private Cofre cofre;
        public Cedulas cedulaSacadas { get; set; }
        public Saque saque;
        
        //Construtor para ATM com valor maximo no cofre
        public ATM ()
	    {       
            cofre = new Cofre();
            cedulaSacadas = new Cedulas();
            saque = new Saque();
	    }
        // Construtor para ATM com valor fornecido para o cofre
        public ATM (int quantidadeNoCofre)
        {
            cofre.Adicionar(quantidadeNoCofre);
        }
         
        public void depositar()
        {

        }

        public void extrato()
        {

        }
    }
}
