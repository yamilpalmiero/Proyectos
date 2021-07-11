using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;


namespace Test_Unitarios
{
    [TestClass]
    public class TestMedicamento
    {
        [TestMethod]
        public void Probar_Constructor()
        {
            //ARRANGE
            Inyectable inyectable;

            //ACT
            inyectable = new Inyectable("Corticoides", 50, 500, -25.5f, Inyectable.EAplicacion.Intramuscular);

            //ASSERT
            Assert.IsNotNull(inyectable);
        }

        [TestMethod]
        public void Constructor_Nombre_Valido()
        {
            //ARRANGE
            Inyectable inyectable;
            string nombre = "Sputnik V";

            //ACT
            inyectable = new Inyectable(nombre, 50, 500, -25.5f, Inyectable.EAplicacion.Endovenosa);

            //ASSERT 
            Assert.AreEqual(nombre, inyectable.Nombre);
        }
    }

}
