using NUnit.Framework;
using roleplay;
using System;

namespace TestLibrary
{
    public class TestElfo
    {
        public Elfo elfo;
        public Item masterSword;
        public Item escudoHyliano;

        [SetUp]
        public void Setup()
        {

        }
       

        [Test]
        public void TestInicializacionElfo()
        {
            Assert.AreEqual("Link", elfo.Nombre);
           Assert.AreEqual(200, elfo.Vida);
            Assert.AreEqual(20, elfo.Ataque);
            Assert.AreEqual(100, elfo.Mana);
        }

        [Test]
        public void TestCargarMana()
        {
            var resultado = elfo.RecargaMana(50);
            Assert.AreEqual("Aumentaste el mana en 50 puntos", resultado);
            Assert.AreEqual(150, elfo.Mana);  // Verificamos si el mana fue actualizado correctamente

            resultado = elfo.RecargaMana(200);  // Intentamos sobrecargar el mana
            Assert.AreEqual("El maná está al maximo", resultado);  // Aseguramos que no supere el máximo
        }

        [Test]
        public void TestAgregarItem()
        {
            elfo.AgregarItem(masterSword);
            elfo.AgregarItem(escudoHyliano);
            Assert.AreEqual(2, elfo.Item.Count);  // Cambiamos a elfo.Item en plural
        }

        [Test]
        public void TestCuracion()
        {
            elfo.Vida = 180;
            elfo.Curacion(15);
            Assert.AreEqual(195, elfo.Vida);  // Verificamos la curación

            elfo.Curacion(25);
            Assert.AreEqual(195, elfo.Vida);  // La vida no debe exceder el máximo
        }

        [Test]
        public void TestAtacarConItem()
        {
            elfo.AgregarItem(masterSword);
            int valorAtaque = elfo.AtacarConItems(masterSword);
            Assert.AreEqual(60, valorAtaque); // 20 + 40 (Ataque del Elfo + Ataque del item)
        }

        [Test]
        public void TestRecibirAtaqueSinDefensa()
        {
            elfo.Defender(40, "Bokoblin");
            Assert.AreEqual(160, elfo.Vida);  // El ataque es directo porque no tiene items de defensa
        }

        [Test]
        public void TestRecibirAtaqueConDefensa()
        {
            elfo.AgregarItem(escudoHyliano);
            elfo.Defender(60, "Bokoblin");
            Assert.AreEqual(190, elfo.Vida);  // 60 de daño, pero el escudo defiende 60, entonces solo resta 10
        }
    }
}
