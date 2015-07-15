using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banco;

namespace UnitTestATM
{
    [TestClass]
    public class TestarSaque
    {
        // Arrange ACt Assert
        [TestMethod]        
        public void possoCriarUmObjetoSaque()
        {
            var saque = new Saque();           
        }
        [TestMethod]        
        public void possoSacarValorValido()
        {
            var saque = new Saque();
            var cedulas = saque.sacar(200);
            Assert.IsNotNull(saque.valorSacado);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void naoPossoSacarValorInvalido()
        {
            var saque = new Saque();
            var cedulas = saque.sacar(201);
        }
        [TestMethod]
        public void ValorSacadoEhValido()
        {
            var saque = new Saque();
            Cedulas valorSacado = saque.sacar(170);
            Assert.IsTrue(
                valorSacado[Notas.Cem] == 1 &&
                valorSacado[Notas.Cinquenta] == 1 &&
                valorSacado[Notas.Vinte] == 1 &&
                valorSacado[Notas.Dez] == 0 &&
                valorSacado[Notas.Cinco] == 0 &&
                valorSacado[Notas.Dois] == 0
                );

        }
     
    }
}
