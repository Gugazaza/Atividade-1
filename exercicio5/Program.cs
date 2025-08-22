public class program
{
    public static void Main(string[] args)
    {
        int horas_trabalhados, horas, salário;
        Console.Write("Escreva o valor da hora do seu trabalho e o número de horas trabalhadas: \n");
        horas_trabalhados = int.Parse(Console.ReadLine());
        horas = int.Parse(Console.ReadLine());

        salário = horas_trabalhados * horas;

        Console.Write("O valor de seu salário e de: \n" + salário);

    }
}