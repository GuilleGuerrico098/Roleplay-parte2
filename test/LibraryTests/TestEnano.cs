using NUnit.Framework;

namespace roleplay
{
    public class TestEnano
    {
        private Enano enano;
        private Item botasDeHierro;
        private Item tunicaZora;

        [SetUp]
        public void Setup()
        {
            enano = new Enano("parla");
            botasDeHierro = Item.BotasDeHierro;
            tunicaZora = Item.TunicaZora;
        }

        [Test]
        public void TestInicializacionEnano()
        {
            Assert.AreEqual("Darunia", enano.Nombre);
            Assert.AreEqual(250, enano.Vida);
            Assert.AreEqual(50, enano.Ataque);
        }

        [Test]
        public void TestAgregarItem()
        {
            enano.AgregarItem(botasDeHierro);
            enano.AgregarItem(tunicaZora);
            Assert.AreEqual(2, enano.Item.Count);
        }

        [Test]
        public void TestAtacarConItems()
        {
            enano.AgregarItem(botasDeHierro);
            int valorAtaque = enano.Atacar();
            Assert.AreEqual(50, valorAtaque); // Ataque base sin incremento
        }

        [Test]
        public void TestDefender()
        {
            enano.AgregarItem(botasDeHierro);
            enano.AgregarItem(tunicaZora);
            enano.Defender(100, "Madruta");
            Assert.AreEqual(200, enano.Vida); // 250 - 100 + (30+20) defensa
        }
    }
}