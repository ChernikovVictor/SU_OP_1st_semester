using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите исходную строку");
            MyClass a = new MyClass(Console.ReadLine());
            string buf = "3";
            while (buf != "0")
            {
                switch (buf)
                {
                    case "1":
                        Console.Clear();
                        string old_word, new_word;
                        Console.WriteLine("Введите слово, которое нужно заменить");
                        old_word = Console.ReadLine();
                        Console.WriteLine("Введите слово-замену");
                        new_word = Console.ReadLine();
                        a.ReplaceWords(char.ToLower(old_word[0]) + old_word.Substring(1, old_word.Length - 1), new_word);
                        a.ReplaceWords(char.ToUpper(old_word[0]) + old_word.Substring(1, old_word.Length - 1), new_word);
                        buf = "3";
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Введите искомую подстроку");
                        string substr = Console.ReadLine();
                        int k = 0;
                        k += a.AmtOfSubstr(char.ToLower(substr[0]) + substr.Substring(1, substr.Length - 1));
                        k += a.AmtOfSubstr(char.ToUpper(substr[0]) + substr.Substring(1, substr.Length - 1));
                        Console.WriteLine("Исходная строка: " + a.St + "\n" +
                                          "Колличество вхождений подстроки \"{0}\" в строку: {1}", substr, k);
                        Console.WriteLine("Нажмите Enter");
                        Console.ReadLine();
                        buf = "3";
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(a.St + "\n" +
                                          "Число букв в строке: " + a.AmtOfLetters() + "\n" +
                                          "Средняя длина слова: " + a.AverageLengthOfWord());
                        if (a.IsPalindrome())
                            Console.WriteLine("Строка является палиндромом");
                        else
                            Console.WriteLine("Строка не является палиндромом");
                        if (a.IsDate())
                            Console.WriteLine("Строка является датой");
                        else
                            Console.WriteLine("Строка не является датой");
                        Console.WriteLine("Меню:\n" +
                                          "1. Заменить слова в строке на заданное\n" +
                                          "2. Найти колличество вхождений подстроки в строке\n" +
                                          "0. Выход");
                        buf = Console.ReadLine();
                        break;
                    case "0":
                        break;
                    default:
                        buf = "3";
                        break; 
                }
            }

        }
    }
}