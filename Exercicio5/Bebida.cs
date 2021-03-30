using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Bebida : ItemMenu
    {
        public Bebida(float bebidaGrande, float bebidaMedia, float bebidaPequena, string nome) : base (nome)
        {
            BebidaGrande = bebidaGrande;
            BebidaMedia = bebidaMedia;
            BebidaPequena = bebidaPequena;

        }

        public float BebidaGrande { get; private set; }
        public float BebidaMedia { get; private set; }
        public float BebidaPequena { get; private set; }

        public override void InformarPreço()
        {
            Console.WriteLine($"Bebida Grande {BebidaGrande.ToString("C")}");
            Console.WriteLine($"Bebida Media {BebidaMedia.ToString("C")}");
            Console.WriteLine($"Bebida Pequena {BebidaPequena.ToString("C")}");
        }

    }
}
