namespace roleplay
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonaje elfo = new Elfo("Link");
            IPersonaje enano = new Enano("Darunia");
            IPersonaje mago = new Mago("Zelda");
            
            Item espada = Item.MasterSword;
            Item espadagrande = Item.EspadaBiggoron;
            Item escudo = Item.EscudoHyliano;
            Item botas = Item.BotasDeHierro;
            Item tunica = Item.TunicaZora;

            elfo.AgregarItem(espada);
            elfo.AgregarItem(escudo);

            enano.AgregarItem(botas);
            enano.AgregarItem(tunica);

            mago.AgregarItem(tunica);
            if (mago is Mago EsMago)
            {
                EsMago.AgregarHabilidad(Habilidades.Agi);
                EsMago.AgregarHabilidad(Habilidades.Ziodyne);
                EsMago.Estudio(20);
            }
            
            Console.WriteLine("Ataques y habilidades:");

            int ataqueElfo = elfo.AtacarConItems(espada);
            enano.Defender(ataqueElfo, elfo.Nombre);
            
            int ataqueEnano = enano.AtacarConItems(espadagrande);
            mago.Defender(ataqueEnano, enano.Nombre);

            Habilidades habilidades = Habilidades.Ziodyne;
            int ataqueMago = 0;
            if (mago is Mago EsBuenMago)
            {
                ataqueMago = EsBuenMago.AtacarConHabilidades(habilidades: habilidades);
            }
            elfo.Defender(ataqueMago, mago.Nombre);
            if (elfo is Elfo ElfoGrande)
            {
                ElfoGrande.Curacion(30);
            }
            
        }
    }
}