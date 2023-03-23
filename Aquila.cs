using esercizio1;
using esercizio2;


public class Aquila : Animale, IVolare
{
    public void Verso()
    {
        Console.WriteLine("Coccodè");
    }

    public void Mangia()
    {
        Console.WriteLine("Conigli");
    }
    public void Vola()
    {
        Console.WriteLine("Sto volando!");
    }
}
