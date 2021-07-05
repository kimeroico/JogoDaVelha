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
            var jogada = string.Empty;
            var pecaTipo = string.Empty;
            var count = 0;
            var peca = 0;
            List<string> tab = new List<string>() { "-", "-", "-", "-", "-", "-", "-", "-", "-" };

            //jogo
            while (saida != "fim")
            {
                Console.Clear();
                Console.WriteLine($"c {tab[6]} {tab[7]} {tab[8]}\nb {tab[3]} {tab[4]} {tab[5]}\na {tab[0]} {tab[1]} {tab[2]}\n  1 2 3");

                Console.WriteLine("Selecione a peça 1-'X', 2-'O' ");
                peca = int.Parse(Console.ReadLine());

                Console.WriteLine("Selecione um Posição:");
                jogada = Console.ReadLine();
                switch (jogada)
                {
                    case "a1":
                        Movimento(tab, 0, peca, pecaTipo);
                        break;
                    case "a2":
                        Movimento(tab, 1, peca, pecaTipo);
                        break;
                    case "a3":
                        Movimento(tab, 2, peca, pecaTipo);
                        break;
                    case "b1":
                        Movimento(tab, 3, peca, pecaTipo);
                        break;
                    case "b2":
                        Movimento(tab, 4, peca, pecaTipo);
                        break;
                    case "b3":
                        Movimento(tab, 5, peca, pecaTipo);
                        break;
                    case "c1":
                        Movimento(tab, 6, peca, pecaTipo);
                        break;
                    case "c2":
                        Movimento(tab, 7, peca, pecaTipo);
                        break;
                    case "c3":
                        Movimento(tab, 8, peca, pecaTipo);
                        break;
                    default:
                        saida = "fim";
                        break;
                }
                Console.Clear();
                Console.WriteLine($"c {tab[6]} {tab[7]} {tab[8]}\nb {tab[3]} {tab[4]} {tab[5]}\na {tab[0]} {tab[1]} {tab[2]}\n  1 2 3");

                count++;
                saida = Partida(tab, count, saida); 
            }
        }

        private static string Partida(List<string> tab, int count, string saida)
        {
            //O
            bool ho1 = (new[] { tab[0], tab[1], tab[2] }.All(x => x == "O"));
            bool ho2 = (new[] { tab[3], tab[4], tab[5] }.All(x => x == "O"));
            bool ho3 = (new[] { tab[6], tab[7], tab[8] }.All(x => x == "O"));
            bool vo1 = (new[] { tab[0], tab[3], tab[6] }.All(x => x == "O"));
            bool vo2 = (new[] { tab[1], tab[4], tab[7] }.All(x => x == "O"));
            bool vo3 = (new[] { tab[2], tab[5], tab[8] }.All(x => x == "O"));
            bool to1 = (new[] { tab[0], tab[4], tab[8] }.All(x => x == "O"));
            bool to2 = (new[] { tab[6], tab[4], tab[2] }.All(x => x == "O"));
            //X
            bool hx1 = (new[] { tab[0], tab[1], tab[2] }.All(x => x == "X"));
            bool hx2 = (new[] { tab[3], tab[4], tab[5] }.All(x => x == "X"));
            bool hx3 = (new[] { tab[6], tab[7], tab[8] }.All(x => x == "X"));
            bool vx1 = (new[] { tab[0], tab[3], tab[6] }.All(x => x == "X"));
            bool vx2 = (new[] { tab[1], tab[4], tab[7] }.All(x => x == "X"));
            bool vx3 = (new[] { tab[2], tab[5], tab[8] }.All(x => x == "X"));
            bool tx1 = (new[] { tab[0], tab[4], tab[8] }.All(x => x == "X"));
            bool tx2 = (new[] { tab[6], tab[4], tab[2] }.All(x => x == "X"));

            if (ho1 || ho2 || ho3 || vo1 || vo2 || vo3 || to1 || to2)
            {
                Console.WriteLine($"Partida terminada! o jogador 'O' ganhou essa partida!");
                return "fim";
            }
            else if (hx1 || hx2 || hx3 || vx1 || vx2 || vx3 || tx1 || tx2)
            {
                Console.WriteLine($"Partida terminada! o jogador 'X' ganhou essa partida!");
                return "fim";
            }
            else if (count == 9)
            {
                Console.WriteLine("DEU VELHA!");
                return "fim"; ;
            }
            else
            {
                return "";
            }
        }

        private static void Movimento(List<string> lista, int index, int peca, string pecaTipo)
        {
            pecaTipo = Peca(peca, pecaTipo);
            bool statusPosicao = PosicaoValida(lista, index);

            if (statusPosicao)
            {
                lista[index] = pecaTipo;
                return;
            }
            else
            {
                Console.WriteLine("Posição invalida");
                Console.WriteLine("Clique 'Enter' para tentar novamente!");
                Console.ReadLine();
            }
        }

        private static bool PosicaoValida(List<string> lista, int index)
        {
            if (lista[index] == "X" || lista[index] == "O")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static string Peca(int peca, string pecaTipo)
        {
            if (peca == 1)
            {
                return pecaTipo = "X";
            }
            else if (peca == 2)
            {
                return pecaTipo = "O";
            }
            else
            {
                Console.WriteLine("Opção de peça inválida!");
                Console.WriteLine("Clique 'Enter' para tentar novamente!");
                Console.ReadLine();
                return "-";
            }

        }



    }
}
