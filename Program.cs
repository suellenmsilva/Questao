using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Questao
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<int>();
            int dayBuy = 0;
            int daySale = 0;
            int buy = 0;
            int sale = 0;

            WriteLine("Digite o tamanho do array: ");
            var size = int.Parse(ReadLine());

            WriteLine("Digite os valores do array: ");
            for (int i = 0; i < size; i++)
            {
                input.Add(int.Parse(ReadLine()));
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == input.Min())
                {
                    dayBuy = i + 1;
                    buy = input[i];
                    i = dayBuy;
                }
                else if (i + 1 < size)
                {
                    if (input[i] > input[i + 1])
                    {
                        if (dayBuy > 0)
                        {
                            sale = input[i];
                            daySale = i + 1;
                        }
                    }
                }

            }
            if (sale - buy > 0)
                Write($"{sale - buy}(Comprou no dia {dayBuy} e vendeu no dia {daySale})");
            else
                Write($"0 (Nesse caso nenhuma transação deve ser feita, lucro máximo igual a 0)");
        }
    }
}
