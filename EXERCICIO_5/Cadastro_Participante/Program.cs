using System;
using System.Globalization;

namespace TesteInga;

class Program
{
    static void Main(string[] args)
    {
        string inputUser;
        Console.Clear();
        Console.Write("Digite seu nome completo: ");
        inputUser = Console.ReadLine();
        string nameUser = ValidName(inputUser);

        Console.Write("Digite sua idade: ");
        inputUser = Console.ReadLine();
        int ageUser = ValidAge(inputUser);

        Console.WriteLine("Usuário cadastrado com sucesso!");
    }

    static string ValidName(string inputUser)
    {
        while (true)
        {
            if (inputUser.Length >= 5)
            {
                return inputUser;
            }
            else
            {
                Console.WriteLine("Nome inválido!");
                Console.Write("Digite seu nome completo: ");
                inputUser = Console.ReadLine();
            }
        }
    }

    static int ValidAge(string inputUser)
    {
        int.TryParse(inputUser, out int isIntegerValue);
        while (true)
        {
            if (isIntegerValue < 18 || isIntegerValue > 100)
            {
                Console.Write("Digite um valor acima de 18 e menor que 100: ");
                inputUser = Console.ReadLine();
                int.TryParse(inputUser, out isIntegerValue);
            }
            else
            {
                return isIntegerValue;
            }            
        }
        
    }
}