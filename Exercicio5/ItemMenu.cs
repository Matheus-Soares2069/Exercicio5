using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio5
{
    class ItemMenu
    {
        public string Nome { get; protected set; }

        public ItemMenu (string nome)
        {
            Nome = nome;
        }

        public void ImprimirNome()
        {
            Console.WriteLine($"{Nome}");
        }
        public virtual void InformarPreço()
        {
        }
    }
}
