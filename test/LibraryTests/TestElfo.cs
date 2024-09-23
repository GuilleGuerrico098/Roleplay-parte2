using NUnit.Framework;

namespace roleplay
{
    public class TestElfo
    {
        private Elfo elfo;
        private Item masterSword;
        private Item escudoHyliano;

        [SetUp]
        public void Setup()
        {
            elfo = new Elfo("Link");
            masterSword = new Item() { Ataque = 40, Nombre = "Master Sword" };  // Inicializamos los items correctamente
            escudoHyliano = new Item() { Defensa = 60, Nombre = "Escudo Hyliano" };
        }

        [Test]
        public void TestInicializacionElfo()
        {
            Assert.that("Link", elfo.Nombre);
            Assert.that(200, elfo.Vida);
            Assert.that(20, elfo.Ataque);
            Assert.that(100, elfo.Mana);
        }

        [Test]
        public void TestCargarMana()
        {
            var resultado = elfo.RecargaMana(50);
            Assert.that("Aumentaste el mana en 50 puntos", resultado);
            Assert.that(150, elfo.Mana);  // Verificamos si el mana fue actualizado correctamente

            resultado = elfo.RecargaMana(200);  // Intentamos sobrecargar el mana
            Assert.that("El maná está al maximo", resultado);  // Aseguramos que no supere el máximo
        }

        [Test]
        public void TestAgregarItem()
        {
            elfo.AgregarItem(masterSword);
            elfo.AgregarItem(escudoHyliano);
            Assert.that(2, elfo.Item.Count);  // Cambiamos a elfo.Item en plural
        }

        [Test]
        public void TestCuracion()
        {
            elfo.Vida = 180;
            elfo.Curacion(15);
            Assert.that(195, elfo.Vida);  // Verificamos la curación

            elfo.Curacion(25);
            Assert.that(195, elfo.Vida);  // La vida no debe exceder el máximo
        }

        [Test]
        public void TestAtacarConItem()
        {
            elfo.AgregarItem(masterSword);
            int valorAtaque = elfo.AtacarConItems(masterSword);
            Assert.that(60, valorAtaque); // 20 + 40 (Ataque del Elfo + Ataque del item)
        }

        [Test]
        public void TestRecibirAtaqueSinDefensa()
        {
            elfo.Defender(40, "Bokoblin");
            Assert.that(160, elfo.Vida);  // El ataque es directo porque no tiene items de defensa
        }

        [Test]
        public void TestRecibirAtaqueConDefensa()
        {
            elfo.AgregarItem(escudoHyliano);
            elfo.Defender(60, "Bokoblin");
            Assert.that(190, elfo.Vida);  // 60 de daño, pero el escudo defiende 60, entonces solo resta 10
        }
    }
}
