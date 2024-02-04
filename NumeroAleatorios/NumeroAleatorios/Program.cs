// See https://aka.ms/new-console-template for more information
using System;

class NumAlea {
    
    static void Main() {

        Random nalea = new Random();               
        List<int> num = new List<int>();
        int menorNum = Int32.MaxValue;
        int maiorNum = Int32.MinValue;
        string numLinha = "";
        for (int i = 0; i < 10; i++) {
            int numAlea = nalea.Next(0, 101);
            numLinha += numAlea + " ";

            if (numAlea < menorNum) {
                menorNum = numAlea;
            }
            if (numAlea > maiorNum) { 
                maiorNum = numAlea;
            }
        }
        
        Console.WriteLine(numLinha);       
        Console.WriteLine($"Menor números: {menorNum}");
        Console.WriteLine($"Maior números: {maiorNum}");
    }
}

