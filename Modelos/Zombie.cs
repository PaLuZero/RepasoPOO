using System;

namespace RepasoPoo.Modelos
{
    public class Zombie : Personaje
    {
        public Zombie(string nombre, int vida, int ataque)
            : base(nombre, vida, ataque, "Infectado")
        {
        }

        public override void Atacar(Personaje enemigo)
        {
            Console.WriteLine($"{Nombre} muerde brutalmente.");
            base.Atacar(enemigo);
        }
    }
}

