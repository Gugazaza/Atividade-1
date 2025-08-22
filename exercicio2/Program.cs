using System.Net.Sockets;

public class program
{
    public static void Main(string[] args)
    {
        int Neymar1, Neymar2, Neymar3, soma, divisao;

        Console.Write("Escreva três números: \n");
        Neymar1 = int.Parse(Console.ReadLine());
        Neymar2 = int.Parse(Console.ReadLine());
        Neymar3 = int.Parse(Console.ReadLine());

        soma = (Neymar1 + Neymar2 + Neymar3)/3;
        
        Console.WriteLine("O resultado da média é: \n"+ soma);




    }
}