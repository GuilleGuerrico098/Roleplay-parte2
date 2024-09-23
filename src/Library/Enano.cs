using System.Collections;

namespace roleplay
{
    public class Enano : IPersonaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public ArrayList Item { get; set; } = new ArrayList();

        public Enano(string nombre)
        {
            Nombre = nombre;
            Vida = 250;
            Ataque = 50;
        }

        public void AgregarItem(Item item)
        {
            Item.Add(item);
        }

        public int AtacarConItems(Item item)
        {
            int valor = Ataque;
            if (Item.Contains(item))
            {
                valor += item.Ataque;
            } 
            return valor;
        }

        public void Defender(int ataque, string rival)
        {
            int vida = Vida;
            foreach (Item item in Item)
            {
                vida += item.Defensa;
            }

            Vida -= ataque;
            Console.WriteLine($"{Nombre} fue atacado por {rival}, su vida disminuyyó hasta {Vida}");
        }
    }
}