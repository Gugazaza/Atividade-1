public class program
{
    public static void Main(string[] args)
    {
        int raiz, dobro, triplo, numero;

        Console.Write("Escreva um número: \n");
        numero = int.Parse(Console.ReadLine());
        dobro = numero * 2;
            triplo = numero * 3;
                raiz = numero * numero;

        Console.WriteLine("A raiz de número é : " + raiz);
        Console.WriteLine("O dobro do número é: " + dobro);
        Console.WriteLine("O triplo do número é: " + triplo);
    }
}