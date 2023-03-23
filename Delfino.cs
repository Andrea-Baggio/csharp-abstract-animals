using esercizio1;
using esercizio2;

public class Delfino : Animale, INuotare
{
    public void Verso()
    {
        Console.WriteLine("Roar");
    }

    public void Mangia()
    {
        Console.WriteLine("Pesce");
    }

    public void Nuota()
    {
        Console.WriteLine("Sto nuotando!");
    }
}