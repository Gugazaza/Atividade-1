public class program
{
    public static void Main(string[] args)
    {
        int numero;

        Console.Write("Escolha um número: \n");
        numero = int.Parse(Console.ReadLine());
        Console.Write("O antecessor do número é: \n"+ (numero - 1)+ "\n");
        Console.Write("O sucessor do número é: \n" + (numero + 1)+ "\n");
    }
}