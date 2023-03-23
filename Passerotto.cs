using esercizio1;
using esercizio2;


public class Passerotto : Animale, IVolare
{
    public void Verso()
    {
        Console.WriteLine("Cip Cip");
    }

    public void Mangia()
    {
        Console.WriteLine("Vermi");
    }

    public void Vola()
    {
        Console.WriteLine("Sto volando!");
    }
}
