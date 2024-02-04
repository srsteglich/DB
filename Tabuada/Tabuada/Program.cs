// See https://aka.ms/new-console-template for more information

class Tabua
{
    static void Main()
    {
        Console.WriteLine("Digite um número positivo: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) 
        {
            int resto = num * i;
            Console.WriteLine($"{num} X {i} = {resto}");
        }
        Console.ReadKey();
    }
}
