using System;

namespace Func_e_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> func = Funcao;
            Console.WriteLine(func(1));

            Action<string, int> action = Procedimento;
            action("teste", 1);

            var funcAnonima = new Func<int, int>(arg => arg);
            Console.WriteLine(funcAnonima(1));

            var actionAnonima = new Action<string, int>((arg1, arg2) =>
            {
                Console.WriteLine($"arg1 = {arg1}");
                Console.WriteLine($"arg2 = {arg2}");
            });

            actionAnonima("teste", 1);
        }

        static int Funcao(int arg)
        {
            return arg;
        }

        static void Procedimento(string arg1, int arg2)
        {
            Console.WriteLine($"arg1 = {arg1}");
            Console.WriteLine($"arg2 = {arg2}");
        }
    }
}
