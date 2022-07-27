using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password_generator
{
    public class Generation
    {
        public static string Password(int a)
        {
            if (a == 1)
            {

                Random random = new Random();

                var vaule = random.Next();
                var vaule1 = random.Next(vaule);


                Console.WriteLine($"Ваш сгенерированный пароль: {vaule1}");
            }
            if (a == 2)
            {
                {
                    string iPass = "";
                    string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "B", "C", "D", "F", "G", "H", "J", "K", "L", "M", "N", "P", "Q", "R", "S", "T", "V", "W", "X", "Z", "b", "c", "d", "f", "g", "h", "j", "k", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "z", "A", "E", "U", "Y", "a", "e", "i", "o", "u", "y" };
                    Random rnd = new Random();
                    for (int i = 0; i < 52; i = i + 1)
                    {
                        iPass = iPass + arr[rnd.Next(0, 57)];

                        string str = iPass;
                        string result = SplitStr(str, 4);

                        string SplitStr(string str, int maxSymbols)
                        {
                            var sb = new StringBuilder();
                            var counter = 0;
                            foreach (var element in str)
                            {
                                if (counter == maxSymbols)
                                {
                                    sb.Append("-");
                                    counter = 0;
                                }

                                sb.Append(element);
                                counter++;

                                Console.WriteLine(sb);

                            }
                            return sb.ToString();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Введённое число - некоректно.");
            }
            return "";
        }
    }
}

