public class program
{
    public static void Main(string[] args)
    {
        double num1, num2, divisao;
        int divisaoint;

        Console.Write("Digite o primeiro número: \n");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("O segundo númerp: \n");
        num2 = int.Parse(Console.ReadLine());

        divisaoint = (int) (num1 / num2);
        divisao = num1 / num2;

        Console.WriteLine("O resultado da divisão inteira é: " + divisaoint);
        Console.WriteLine("O resultado da divisão real é: " + divisao);
    }
}