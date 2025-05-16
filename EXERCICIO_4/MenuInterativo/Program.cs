using System;
using System.Globalization;
using System.Threading.Tasks;

namespace TesteInga;

class Program
{
    static List<Dictionary<string, object>> newEvents = new List<Dictionary<string,object>>(); 
    static async Task Main(string[] args)
    {
        bool exit = false;
        Console.Clear();
        int id = 0;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("==== MENU INTERATIVO ====");
            Console.WriteLine("[1] - Cadastrar Evento");
            Console.WriteLine("[2] - Ver Detalhes");
            Console.WriteLine("[3] - Sair");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("==== MENU CADASTRO DO EVENTO ====");
                    Console.Write("Digite o nome do evento: ");
                    string nomeEvento = Console.ReadLine();
                    DateTime dataConvert;
                    string formato = "dd/MM/yyyy";

                    while (true)
                    {
                        Console.Write("Data do evento (dd/MM/yyyy): ");
                        string dateEvent = Console.ReadLine();

                        if (DateTime.TryParseExact(dateEvent, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvert))
                        {
                            if (dataConvert >= DateTime.Now)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Data inválida! Por favor, digite uma data superior a a {DateTime.Now.ToString("dd/MM/yyyy")}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("O campo: 'Data do evento' foi preenchido incorretamente, por favor preencha com tipo de dados do campo");
                        }
                    }
                    Dictionary<string, object> newEvent = new Dictionary<string, object>();
                    id++;
                    newEvent.Add("id", id);
                    newEvent.Add("name", nomeEvento);
                    newEvent.Add("dateEvent", dataConvert);
                    newEvents.Add(newEvent);
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("==== EVENTOS CADASTRADOS ====");
                    if (newEvents.Count == 0)
                    {
                        Console.WriteLine("Não tem eventos cadastrados");
                    }
                    else
                    {
                        foreach (var item in newEvents)
                        {
                            foreach (var obj in item)
                            {
                                if (obj.Value is DateTime date)
                                {
                                    Console.WriteLine($"{obj.Key} = {date.ToString("dd/MM/yyyy")}");
                                }
                                else
                                {
                                    Console.WriteLine($"{obj.Key} = {obj.Value}");                                    
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Obrigado por usar o programa!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Digite uma opção válida!");
                    await Task.Delay(2000);
                    break;
            }
        }

    }
}