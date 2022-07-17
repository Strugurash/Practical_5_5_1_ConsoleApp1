using System;

namespace Practical_5_5_1_ConsoleApp1
{
    internal class Program
    {
        static void OutputWords(string[] words) // метод вывода слов
        {

            foreach (string word in words) // цикл перебора по элементам массива из слов
            {
                Console.WriteLine(word);
            }

        }
        static void Main(string[] args) // главный метод (программа)
        {
            Console.Write(" Введите предложение : \n");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // разделение предложения на слова
            OutputWords(words); // вызов метода вывода,описанного ранее
        }
    }
}
