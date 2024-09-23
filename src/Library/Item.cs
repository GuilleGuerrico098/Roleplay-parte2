namespace roleplay
{
    public class Item
    {
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }

        public static Item MasterSword { get; } = new Item { Nombre = "Master Sword", Ataque = 40, Defensa = 0 };
        public static Item EscudoHyliano { get; } = new Item { Nombre = "Escudo Hyliano", Ataque = 0, Defensa = 60 };
        public static Item EspadaBiggoron { get; } = new Item { Nombre = "Espada Biggoron", Ataque = 50, Defensa = 0 };
        public static Item BotasDeHierro { get; } = new Item { Nombre = "Botas de Hierro", Ataque = 0, Defensa = 30 };
        public static Item TunicaZora { get; } = new Item { Nombre = "Túnica Zora", Ataque = 0, Defensa = 20 };
    }
}