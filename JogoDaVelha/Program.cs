using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            var saida = string.Empty;
            var jogada1 = string.Empty;
            var pecaTipo = string.Empty;
            var count = 0;
            var peca = 0;
            var jogada = new Jogada();
            List<string> tab = new List<string>() { "-", "-", "-", "-", "-", "-", "-", "-", "-" };

            //jogo
            while (saida != "fim")
            {
                Console.Clear();
                Console.WriteLine($"c {tab[6]} {tab[7]} {tab[8]}\nb {tab[3]} {tab[4]} {tab[5]}\na {tab[0]} {tab[1]} {tab[2]}\n  1 2 3");

                Console.WriteLine("Selecione a peça 1-'X', 2-'O' ");
                peca = int.Parse(Console.ReadLine());

                Console.WriteLine("Selecione um Posição:");
                jogada1 = Console.ReadLine();
                switch (jogada1)
                {
                    case "a1":
                        jogada.Movimento(tab, 0, peca, pecaTipo);
                        break;
                    case "a2":
                        jogada.Movimento(tab, 1, peca, pecaTipo);
                        break;
                    case "a3":
                        jogada.Movimento(tab, 2, peca, pecaTipo);
                        break;
                    case "b1":
                        jogada.Movimento(tab, 3, peca, pecaTipo);
                        break;
                    case "b2":
                        jogada.Movimento(tab, 4, peca, pecaTipo);
                        break;
                    case "b3":
                        jogada.Movimento(tab, 5, peca, pecaTipo);
                        break;
                    case "c1":
                        jogada.Movimento(tab, 6, peca, pecaTipo);
                        break;
                    case "c2":
                        jogada.Movimento(tab, 7, peca, pecaTipo);
                        break;
                    case "c3":
                        jogada.Movimento(tab, 8, peca, pecaTipo);
                        break;
                    default:
                        Console.WriteLine("Posição invalida!"); ;
                        break;
                }
                Console.Clear();
                Console.WriteLine($"c {tab[6]} {tab[7]} {tab[8]}\nb {tab[3]} {tab[4]} {tab[5]}\na {tab[0]} {tab[1]} {tab[2]}\n  1 2 3");

                count++;
                saida = jogada.Partida(tab, count, saida); 
            }
        }



    }
}
