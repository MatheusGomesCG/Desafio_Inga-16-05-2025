using System;

namespace TesteInga;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Digite o número de participantes: ");
        string inputUser = Console.ReadLine();
        int quantityPeople = IsInteger(inputUser);

        if (quantityPeople < 50)
        {
            Console.WriteLine("Evento Pequeno");
        }
        else if (quantityPeople <= 200)
        {
            Console.WriteLine("Evento Médio");
        }
        else
        {
            Console.WriteLine("Evento Grande");
        }

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
}