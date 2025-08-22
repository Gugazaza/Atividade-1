public class program
{
    public static void Main(string[] args)
    {
        int numero1, numero2, numero3;

        numero1 = 1;
        numero2 = 2;
        numero3 = 0;
        Console.Write("O valor do número 1 e : " + numero1 + " O segundo: " + numero2+ "\n");
        numero3 = numero1;
        numero1 = numero2;
        numero2 = numero3;

        Console.Write("O valor do número 1 e : " + numero1 + " O segundo: " + numero2);
    }
}