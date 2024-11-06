// See https://aka.ms/new-console-template for more information

using TareasC_;

class Program
{
    static void Main(string[] args)
    {
        Tablero tablero = new Tablero();

        if (tablero.Resolver())
        {
            Console.WriteLine("Solución encontrada:");
            tablero.MostrarTablero();
        }
        else
        {
            Console.WriteLine("No se encontró una solución.");
        }
    }
}
