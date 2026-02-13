using System;

namespace RepasoPoo.Modelos
{
    public class Personaje
    {
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public string Tipo { get; set; }

        public Personaje(string nombre, int vida, int ataque, string tipo)
        {
            Nombre = nombre;
            Vida = vida;
            Ataque = ataque;
            Tipo = tipo;
        }

        public virtual void Atacar(Personaje enemigo)
        {
            enemigo.RecibirDanio(Ataque);
        }

        public void RecibirDanio(int cantidad)
        {
            Vida -= cantidad;
            if (Vida < 0)
                Vida = 0;
        }

        public void Curarse(int cantidad)
        {
            Vida += cantidad;
        }

        public bool EstaVivo()
        {
            return Vida > 0;
        }

        public void MostrarEstado()
        {
            Console.WriteLine($"{Nombre} - Vida: {Vida}");
        }
    }
}


