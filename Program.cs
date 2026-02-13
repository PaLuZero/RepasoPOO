using System;
using RepasoPoo.Modelos;

namespace RepasoPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldado jugador = new Soldado("Soldado", 100, 20);
            Zombie enemigo = new Zombie("Zombie", 80, 35);

            Console.WriteLine("=== GAME ===");

            while (jugador.EstaVivo() && enemigo.EstaVivo())
            {
                Console.WriteLine("\n--- Estado ---");
                jugador.MostrarEstado();
                enemigo.MostrarEstado();

                Console.WriteLine("\n¿Que harás?");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Curarse (+50 vida)");

                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    jugador.Atacar(enemigo);
                }
                else if (opcion == "2")
                {
                    jugador.Curarse(50);
                    Console.WriteLine("Te has curado 50 puntos de vida.");
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                if (enemigo.EstaVivo())
                {
                    enemigo.Atacar(jugador);
                }
            }

            Console.WriteLine("\n=== GAME OVER ===");

            if (jugador.EstaVivo())
                Console.WriteLine("Has sobrevivido.");
            else
                Console.WriteLine("Has muerto.");

            Console.ReadLine();
        }
    }
}

