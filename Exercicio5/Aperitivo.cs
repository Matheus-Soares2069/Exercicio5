using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class Aperitivo : ItemMenu
    {
        public Aperitivo(float preco, string nome) : base(nome)
        {
            Preco = preco;
        }

        public float Preco { get; private set; }

        public override void InformarPreço()
        {
            Console.WriteLine($"{Preco.ToString("C")}");
        }
    }
}
