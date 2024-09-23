namespace roleplay
{

    public class Habilidades
    {
        public string Nombre { get; set; }
        public int Ataque { get; set; }
        public int Costo { get; set; }

        public static Habilidades Agi { get; } = new Habilidades { Nombre = "Agi", Ataque = 30, Costo = 4 };
        public static Habilidades Agilao { get; } = new Habilidades { Nombre = "Agilao", Ataque = 50, Costo = 8 };
        public static Habilidades Bufula { get; } = new Habilidades { Nombre = "Bufula", Ataque = 45, Costo = 7 };
        public static Habilidades Ziodyne { get; } = new Habilidades { Nombre = "Ziodyne", Ataque = 70, Costo = 16 };
        public static Habilidades Garula { get; } = new Habilidades { Nombre = "Garula", Ataque = 55, Costo = 10 };
        public static Habilidades Mabufudyne { get; } = new Habilidades { Nombre = "Mabufudyne", Ataque = 80, Costo = 22 };
    }
}