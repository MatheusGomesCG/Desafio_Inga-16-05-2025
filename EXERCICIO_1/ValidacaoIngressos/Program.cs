using System;

namespace CadastroIngressos;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Capacidade total: ");
        string inputUser = Console.ReadLine();
        int maxCapacity = IsInteger(inputUser);

        Console.Write("Participantes cadastrados: ");
        inputUser = Console.ReadLine();
        int totalParticipants = IsInteger(inputUser);

        if (totalParticipants > maxCapacity)
        {
            Console.WriteLine("Valor inválido, quantidade superior ao permitido no evento!");

            while (true)
            {
                Console.Write($"Digite um valor menor ou igual a {maxCapacity} e maior que zero: ");
                inputUser = Console.ReadLine();
                totalParticipants = IsInteger(inputUser);
                if (totalParticipants <= maxCapacity)
                {
                    break; 
                }
            }
        }

        Console.Write("Pode Cadastrar mais? ");
        if (totalParticipants < maxCapacity)
        {
            Console.WriteLine("Sim");
        }
        else
        {
            Console.WriteLine("Não");
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