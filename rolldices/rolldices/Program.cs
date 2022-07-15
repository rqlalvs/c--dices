using System;

namespace RollDices
{
    class Program
    {
        static void Main(string[] args)
        {
            int p1randomNum;
            int p2randomNum;

            int p1points = 0;
            int p2points = 0;

            Random r = new Random();


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Pressione alguma tecla para rolar os dados");
                Console.WriteLine();
                Console.ReadKey();

                p1randomNum = r.Next(1, 7);
                Console.WriteLine("Voce rolou um: " + p1randomNum);

                Console.WriteLine("Aguardando rolagem adversaria...");
                System.Threading.Thread.Sleep(1000);

                p2randomNum = r.Next(1, 7);
                Console.WriteLine("Seu adversario rolou um: " + p2randomNum);

                if (p1randomNum > p2randomNum)
                {
                    p1points++;
                    Console.WriteLine();
                    Console.WriteLine("Voce ganhou essa rodada! Seu placar: " + p1points);
                }
                else if (p2randomNum == p1randomNum)
                {
                    Console.WriteLine();
                    Console.WriteLine("Empate! Placar geral");
                    Console.WriteLine("Adversario: " + p2points);
                    Console.WriteLine("Voce: " + p1points);
                }
                else
                {
                    p2points++;
                    Console.WriteLine();
                    Console.WriteLine("Voce perdeu essa rodada. Placar adversario: " + p2points);
                }
            }


            if (p1points > p1points)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Voce ganhou!");
                Console.WriteLine("Adversario: " + p2points);
                Console.WriteLine("Voce: " + p1points);
            }
            else if (p1points == p1points)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Empate! Placar geral");
                Console.WriteLine("Adversario: " + p2points);
                Console.WriteLine("Voce: " + p1points);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Voce perdeu");
                Console.WriteLine("Adversario: " + p2points);
                Console.WriteLine("Voce: " + p1points);
            }

            Console.ReadKey();
        }
    }
}
