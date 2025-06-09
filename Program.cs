using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Window1 window1 = mediator.GetWindow1();
            Window2 window2 = mediator.GetWindow2();

            Console.WriteLine("=== Aplicação com Padrão Mediator ===");
            Console.WriteLine("Comandos: 1 <texto> | 2 <texto> | b1 | b2 | sair");
            Console.WriteLine("1 <texto>: Digitar texto na Janela 1");
            Console.WriteLine("2 <texto>: Digitar texto na Janela 2");
            Console.WriteLine("b1: Pressionar botão da Janela 1 (copia para Janela 2)");
            Console.WriteLine("b2: Pressionar botão da Janela 2 (copia para Janela 1)");
            Console.WriteLine();            string? input;
            while ((input = Console.ReadLine()) != "sair" && input != null)
            {
                if (input.StartsWith("1 "))
                {
                    string text = input.Substring(2);
                    window1.TypeText(text);
                }
                else if (input.StartsWith("2 "))
                {
                    string text = input.Substring(2);
                    window2.TypeText(text);
                }
                else if (input == "b1")
                {
                    window1.ButtonClick();
                }
                else if (input == "b2")
                {
                    window2.ButtonClick();
                }
                else
                {
                    Console.WriteLine("Comando inválido. Use: 1 <texto>, 2 <texto>, b1, b2 ou sair");
                }
                
                Console.WriteLine($"Estado atual - Janela 1: '{window1.GetText()}' | Janela 2: '{window2.GetText()}'");
                Console.WriteLine();
            }
            
            Console.WriteLine("Aplicação encerrada.");
        }
    }
}
