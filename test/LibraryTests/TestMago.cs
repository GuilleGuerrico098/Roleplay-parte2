using NUnit.Framework;

namespace roleplay
{
    public class TestMago
    {
        private Mago mago;
        private Item tunicaZora;
        private Habilidades ziodyne;
        private Habilidades agi;

        [SetUp]
        public void Setup()
        {
            mago = new Mago("Zelda");
            tunicaZora = Item.TunicaZora;
            ziodyne = Habilidades.Ziodyne;
            agi = Habilidades.Agi;
        }

        [Test]
        public void TestInicializacionMago()
        {
            Assert.AreEqual("Zelda", mago.Nombre);
            Assert.AreEqual(150, mago.Vida);
            Assert.AreEqual(100, mago.Mana);
            Assert.AreEqual(20, mago.Ataque);
        }

        [Test]
        public void TestAgregarHabilidad()
        {
            mago.AgregarHabilidad(ziodyne);
            mago.AgregarHabilidad(agi);
            Assert.AreEqual(2, mago.Habilidades.Count);
        }

        [Test]
        public void TestAtacarConHabilidad()
        {
            mago.AgregarHabilidad(agi);
            int valorAtaque = mago.AtacarConHabilidades(habilidades: agi);
            Assert.AreEqual(50, valorAtaque); // 20 (base) + 30 (Agi)
        }

        [Test]
        public void TestDefender()
        {
            mago.AgregarItem(tunicaZora);
            mago.Defender(50, "Rey Bulblin");
            Assert.AreEqual(120, mago.Vida); // 150 - 50 + 20 (defensa túnica)
        }

        [Test]
        public void TestRecargaMana()
        {
            var resultado = mago.RecargaMana(50);
            Assert.AreEqual("Aumentaste el mana en 50 puntos", resultado);
            Assert.AreEqual(150, mago.Mana);

            resultado = mago.RecargaMana(200);
            Assert.AreEqual("El maná está al maximo", resultado);
        }
    }
}