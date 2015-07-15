using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco;


namespace UnitTestATM
{
    [TestClass]
    public class TesteATM
    {
        [TestMethod]
        public void possoCriarUmATM()
        {
            ATM atm = new ATM();
        }
        

        [TestMethod]
        public void possoSacarEmUmATM()
        {
            ATM caixa = new ATM();
            Cedulas cedulasSacadas = caixa.saque.sacar(200);
            Assert.IsTrue(caixa.saque.valorSacado == 200);
        }

    }
}
