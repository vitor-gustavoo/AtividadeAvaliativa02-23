using System;
using System.IO;
using System.Collections;

namespace OrderNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] lines = File.ReadAllLines("ArqLeitura.txt");
            int[] numbers = new int[lines.Length];
            int count = 0;
            Console.WriteLine($"Valores desordenados: {string.Join(" - ", lines)}");

            for (int i = 0; i < lines.Length; i++)
            {
                numbers[i] = int.Parse(lines[i]);
            }
             for (int j = 0; j <= numbers.Length - 2; j++)
            {
                //intArray.Length - 2
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    count = count + 1;
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
                Console.WriteLine($"{String.Join(" - ", numbers)}");
            }
            Console.WriteLine(String.Join(" ", numbers));
            File.WriteAllLines("Ordenado.txt", Array.ConvertAll(numbers, x => x.ToString()));
            Console.WriteLine("Números ordenados com sucesso!");
            Console.WriteLine($"Arquivo de saída: Ordenado.txt");
        }
    }
}