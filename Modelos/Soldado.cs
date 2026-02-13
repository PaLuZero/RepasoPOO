using System;

namespace RepasoPoo.Modelos
{
    public class Soldado : Personaje
    {
        public Soldado(string nombre, int vida, int ataque)
            : base(nombre, vida, ataque, "Humano")
        {
        }

        public override void Atacar(Personaje enemigo)
        {
            Console.WriteLine($"{Nombre} dispara su arma.");
            base.Atacar(enemigo);
        }
    }
}
