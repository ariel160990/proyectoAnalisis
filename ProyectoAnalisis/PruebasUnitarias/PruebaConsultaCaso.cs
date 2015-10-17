using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoAnalisis;


namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaConsultaCaso
    {
        [TestMethod]
        public void ComprobarConsultaCaso()
        {
            int numero = 1;
            Boolean expected=true;
            PruebasCodigo con = new PruebasCodigo();
            con.ConsultarCaso(numero);

            Boolean bandera = con.banderita;
            Assert.AreEqual(expected, bandera);


        }
    }
}
