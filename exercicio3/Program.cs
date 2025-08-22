public class program
{
    public static void Main(string[] args)
    {
        double graus, Conversao;
        Console.WriteLine("Quantos graus célcius esstamos? \n");
        graus = double.Parse(Console.ReadLine());

        Conversao = (graus * 1.8) + 32;

        Console.WriteLine("Estamos em "+ Conversao+ " Fahrenheit");


    }
}
