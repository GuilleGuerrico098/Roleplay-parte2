using System.Collections;

namespace roleplay
{
    public class Elfo : IPersonaje, IElfo, ISeresMagicos
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Mana { get; set; }
        public int VidaBase;
        public int ManaInicial;
        public ArrayList Habilidades { get; set; } = new ArrayList();
        public ArrayList Item { get; set; } = new ArrayList();

        public Elfo(string nombre)
        {
            Nombre = nombre;
            Vida = 200;
            Ataque = 20;
            VidaBase = 200;
            Mana = 100;
            ManaInicial = 100;
        }

        public void AgregarHabilidad(Habilidades habilidades)
        {
            Habilidades.Add(habilidades);
        }

        public void AgregarItem(Item item)
        {
            Item.Add(item);
        }

        public int AtacarConHabilidades(Habilidades habilidades = null)
        {
            int valor = Ataque;

            if (habilidades != null)
            {
                if (Mana >= habilidades.Costo)
                {
                    Mana -= habilidades.Costo;
                    valor += habilidades.Ataque;
                }
                else
                {
                    Console.WriteLine($"Magia insuficiente");
                }
            }
            return valor;
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

        public string RecargaMana(int mana)
        {
            if (mana > ManaInicial)
            {
                return ("El maná está al maximo");
            }
            else
            {
                Mana += mana;
                return ($"Aumentaste el mana en {mana} puntos");
            }
        }

        public void Curacion(int curar)
        {
            if ((Vida + curar) > VidaBase || curar > 20)
            {
                Console.WriteLine(
                    $"{Nombre} no ha podido curarse");
            }
            else
            {
                Vida += curar;
                Console.WriteLine($"{Nombre} recuperó PS, su vida llegó hasta {Vida}");
            }
        }
    }
}