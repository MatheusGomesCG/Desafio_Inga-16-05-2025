using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();    
        Console.Write("Ingressos vendidos: ");
        string inputUser = Console.ReadLine();
        int totalTickets = IsInteger(inputUser);

        Console.Write("Valor do ingresso: ");
        inputUser = Console.ReadLine();
        double valueTicket = IsDouble(inputUser);

        double totalRevenue = valueTicket * totalTickets;
        Console.WriteLine($"Receita total: R${totalRevenue.ToString("F2", CultureInfo.InvariantCulture)}");

    }
    static int IsInteger(string inputUser)
    {
        int.TryParse(inputUser, out int isIntegerValue);
        while (isIntegerValue <= 0)
        {
            Console.Write("Digite um valor acima de zero e igual a inteiro: ");
            inputUser = Console.ReadLine();
            int.TryParse(inputUser, out isIntegerValue);
        }
        return isIntegerValue;
    }

    static double IsDouble(string inputUser)
    {
        double.TryParse(inputUser, out double isDoubleValue);
        while (isDoubleValue <= 0.0)
        {
            Console.Write("Digite um valor acima de zero e igual a real: ");
            inputUser = Console.ReadLine();
            double.TryParse(inputUser, out isDoubleValue);
        }
        return isDoubleValue;
    }
}