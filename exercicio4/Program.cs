public class program
{
    public static void Main(string[] args)
    {
        int valores0, valores1, área;

        Console.Write("Digite a base e a altura do retangulo: \n");
        valores0 = int.Parse(Console.ReadLine());
        valores1 = int.Parse(Console.ReadLine());

        área = valores0 * valores1;

        Console.Write("O valor da área e equivalente a : \n" + área+ "\n\n");

    }
}
