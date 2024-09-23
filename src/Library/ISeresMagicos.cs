namespace roleplay;
using System.Collections;

public interface ISeresMagicos
{
    public int Mana { get; set; }
    public ArrayList Habilidades { get; set; }
    public void AgregarHabilidad(Habilidades habilidades);
    public int AtacarConHabilidades(Habilidades habilidades = null);
    public string RecargaMana(int mana);
}