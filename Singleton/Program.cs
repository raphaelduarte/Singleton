using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador_1 = Singleton.GetInstance;
            jogador_1.Message("A bola esta comigo no meio do campo");

            Singleton jogador_2 = Singleton.GetInstance;
            jogador_2.Message("Recebeu a bola");

            Singleton jogador_3 = Singleton.GetInstance;
            jogador_3.Message("Jogador 3: recebeu o lancamento na linha de fundo");

            Console.ReadKey();
        }
    }

}