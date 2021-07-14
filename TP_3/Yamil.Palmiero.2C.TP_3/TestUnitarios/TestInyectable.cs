using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestInyectable
    {
        [TestMethod]
        public void Probar_Constructor()
        {
            //ARRANGE
            Inyectable inyectable;

            //ACT
            inyectable = new Inyectable("Corticoides", ETipo.Recetado, 10, Eunidad.MiliLitros);

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
            inyectable = new Inyectable(nombre, ETipo.Recetado, 15, Eunidad.MiliLitros);

            //ASSERT 
            Assert.AreEqual(nombre, inyectable.Nombre);
        }
    }
}
