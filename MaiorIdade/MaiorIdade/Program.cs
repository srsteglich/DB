// See https://aka.ms/new-console-template for more information
int idade;
Console.WriteLine("Digite a sua idade: ");
idade = int.Parse(Console.ReadLine());
if (idade >= 18 ) {
    Console.WriteLine(" A sua idade é maior, tem " +  idade + " anos");
}
else {
    Console.WriteLine(" A sua idade é menor, tem " + idade + " anos");
}
