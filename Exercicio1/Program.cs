﻿public class program
{
    public static void Main(string[] args)
    {

        int numero1, numero2, soma;

        Console.Write("selecione um numero: \n");
        numero1 = int.Parse(Console.ReadLine());
        Console.Write("Selecione o segundo número: \n");
        numero2 = int.Parse(Console.ReadLine());

        soma = numero1 + numero2;

        Console.WriteLine("A resposta da soma é: \n" + soma);
    }
}