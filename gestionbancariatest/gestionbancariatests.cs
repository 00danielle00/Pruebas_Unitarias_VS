using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gestionBancariaApp;

namespace gestionbancariatest
{
    [TestClass]
    public class gestionbancariatests
    {
        [TestMethod]
        public void ValidarMetodoIngreso()
        {
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            cuenta.realizarIngreso(ingreso);
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001,"El saldo de la cuenta no es correcto");
        }
    }
}
