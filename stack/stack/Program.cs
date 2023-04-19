using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            /////Задание_1
            try
            {
                Stack<int> num = new Stack<int>();
                int n = 0;
                Console.WriteLine("Введите количество элементов в стеке");
                while (true)
                {

                    n = int.Parse(Console.ReadLine());
                    if (n <= 0) Console.WriteLine("Количество элементов в стеке должно быть больше 0, введите повторно");
                    else break;
                }


                for (int i = 1; i <= n; i++)
                {
                    num.Push(i);
                }

                Console.WriteLine($"Размерность стека: {num.Count}");
                Console.WriteLine($"Верхний элемент стека: {num.Peek()}");
                Console.Write("Содержимое стека:");
                for (int i = 1; i <= n; i++)
                {
                    Console.Write($" {num.Pop()}");
                }
                Console.WriteLine();
                Console.WriteLine($"Новая размерность стека: {num.Count}");

                /////Задание 2
                /*Console.WriteLine("Введите математическое выражение, используя скобки");
                string math = Console.ReadLine();
                string new_math = "";
                int er = 0;
                Stack<char> word1 = new Stack<char>();
                Stack<char> word2 = new Stack<char>();
                StreamWriter sw = File.CreateText("t.txt");
                sw.WriteLine(math);
                sw.Close();
                int i = 0;
                for (i = 0; i < math.Length; i++)
                {
                    char a = math[i];

                    if (a == '(')
                    {

                        word1.Push(a);
                        er = i+1;
                    }
                    else if (a == ')')
                    {

                        word2.Push(a);
                        if (word1.Count < word2.Count) break;
                    }
                }
                if (word1.Count == word2.Count)
                    Console.WriteLine("Скобки сбалансированы");
                else if (word1.Count < word2.Count)
                {
                    Console.WriteLine($"Возможно лишняя скобка ) в {i + 1} позиции");
                    new_math = math.Remove(i, 1);
                }
                else
                {
                    Console.WriteLine($"Возможно лишняя скобка ( в {er} позиции");
                    new_math = math.Remove(er-1, 1);
                }
                if (new_math != "")
                {
                    Console.WriteLine($"Измененное выражение: {new_math}");
                    StreamWriter new_sw = File.CreateText("t1.txt");
                    new_sw.WriteLine(new_math);
                    new_sw.Close();
                }
                    */
            }
            catch
            {
                Console.WriteLine("Ошибка, неверно введены данные");
            }

            Console.ReadKey();
        }
    }
}
