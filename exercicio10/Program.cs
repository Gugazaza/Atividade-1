// See https://aka.ms/new-console-template for more information
public class program
{
    public static void Main(string[] args)
    {
        float valor, valor_desconto, valorFinal, ValorDesconto;
        
        Console.WriteLine("Escreva qual o valor do produto, seu percentual de desconto:");
        valor = float.Parse(Console.ReadLine());
        valor_desconto = float.Parse(Console.ReadLine());

        ValorDesconto = (valor_desconto / 100) * valor;
        valorFinal = valor - ValorDesconto;

        Console.WriteLine("O valor do desconto e de :" + ValorDesconto);
        Console.WriteLine("O valor total do produto e de:" + valorFinal);
    }
}
