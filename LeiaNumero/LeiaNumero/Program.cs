// See https://aka.ms/new-console-template for more information
using System;
    class LeiaNum  {
        static void Main(string[] args)  {
        int num;
        do  {
            Console.WriteLine("Digite um número, (digite 10 para Sair): ");
            num = Convert.ToInt32(Console.ReadLine());
            if ( num == 10) {
                break;
            }
            Console.WriteLine("Voce digitou: " + num);
        } while(num != 10);        
    }
}
    

