namespace roleplay;
using System.Collections;

public interface IPersonaje
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public ArrayList Item { get; set; }
    public void Defender(int ataque, string rival);
    public int AtacarConItems(Item item);
    public void AgregarItem(Item item);
}