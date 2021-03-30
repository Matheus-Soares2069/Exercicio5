using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida CocaCola = new Bebida(7, 4, 3, "Coca Cola");
            Bebida GuaranaJesus = new Bebida(10, 5, 4, "Guarana Jesus");
            Bebida FantaLaranja = new Bebida(6, 3, 2, "Fanta Laranja");
            Aperitivo LinguiçaCalabreça = new Aperitivo(12, "Linguiça Calabreça");
            Aperitivo Carne = new Aperitivo(15, "Carne");

            ItemMenu[] itemMenus = { CocaCola, GuaranaJesus, FantaLaranja, LinguiçaCalabreça, Carne };

            foreach (ItemMenu item in itemMenus)
            {
                item.ImprimirNome();
                item.InformarPreço();
                Console.WriteLine("--------------------------------");
                Console.ReadLine();
            }
        }
    }
}
