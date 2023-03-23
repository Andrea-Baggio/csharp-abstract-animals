namespace esercizio1
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzz...");
        }
    }
}


namespace esercizio2
{
    public interface IVolare
    {
        public void Vola();
    }

    public interface INuotare
    {
        public void Nuota();
    }
}