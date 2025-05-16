using System;
using System.Globalization;

namespace TesteInga;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear(); 
        string inputUser;
        Console.Write("Quantidade de ingressos: ");
        inputUser = Console.ReadLine();
        int quantityTicket = IsInteger(inputUser);

        double valueTicket = 20.00;
        double descountTicket = 0.0;

        Console.Write("Valor a pagar: R$ ");
        if (quantityTicket <= 2)
        {
            Console.WriteLine($"{(valueTicket * quantityTicket).ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else if (quantityTicket <= 4)
        {
            descountTicket = 2 * quantityTicket;
            valueTicket *= quantityTicket;
            Console.WriteLine($"{(valueTicket - descountTicket).ToString("F2", CultureInfo.InvariantCulture)}");
        }
        else
        {
            descountTicket = 5 * quantityTicket;
            valueTicket *= quantityTicket;
            Console.WriteLine($"{(valueTicket - descountTicket).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
    static int IsInteger(string inputUser)
    {
        int.TryParse(inputUser, out int isIntegerValue);
        while (isIntegerValue <= 0 || isIntegerValue > 50)
        {
            Console.Write("Digite um valor acima de zero e menor que 50, e igual a inteiro: ");
            inputUser = Console.ReadLine();
            int.TryParse(inputUser, out isIntegerValue);
        }
        return isIntegerValue;
    }
}