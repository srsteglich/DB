// See https://aka.ms/new-console-template for more information
using System;

enum Jogada
{
    Pedra,
    Papel,
    Tesoura
}

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        bool jogaNov = true;
        Jogada jogadaMaquina = (Jogada)rnd.Next(0, 3); 

        while (jogaNov) {

            Console.WriteLine("Escolha sua jogada:  1 - Pedra,  2 - Papel,  3 - Tesoura");
            int escolhaJogador = Convert.ToInt32(Console.ReadLine());
            Jogada jogadaJogador = (Jogada)(escolhaJogador - 1); 

            Console.WriteLine($"Você escolheu: {jogadaJogador}");
            Console.WriteLine($"A máquina escolheu: {jogadaMaquina}");

            if (jogadaJogador == jogadaMaquina)
            {
                Console.WriteLine("Empate!");
            }
            else if ((jogadaJogador == Jogada.Pedra && jogadaMaquina == Jogada.Tesoura) ||
                     (jogadaJogador == Jogada.Papel && jogadaMaquina == Jogada.Pedra) ||
                     (jogadaJogador == Jogada.Tesoura && jogadaMaquina == Jogada.Papel))
            {
                Console.WriteLine("Ganhou!");
            }
            else
            {
                Console.WriteLine("Perdeu!");
            }
            Console.WriteLine("Quer jogar novamente? (s/n)");
            string resp = Console.ReadLine().Trim().ToLower();
            jogaNov = resp == "s";
        }
    }
}