using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Итоговая_контрольная_работа_по_основному_блоку
{
    internal class Tusk
    {
        static void Main(string[] args)
        {
            


            int ReadInt(string text)
            {
                Console.WriteLine(text);
                return Convert.ToInt32(Console.ReadLine());

            }

            Random random = new Random();
            string GenerateRandomString(int length)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            }



            int numberOfWords = ReadInt("Введите длинну предложения: ");
            int minWordsLenght = 1; //ReadInt("Введите минимальную длинну слова в предложении: ");
            int maxWordsLenght = 5; // ReadInt("Введите максимальную длинну слова в предложении: ");

            string GenerateRandomProposal(int lenght)
            {
                int rand = random.Next(minWordsLenght, maxWordsLenght + 1);
                string proposal = GenerateRandomString(rand);

                for (int i = 0; i <= lenght; i++)
                {
                    rand = random.Next(minWordsLenght, maxWordsLenght + 1);
                    proposal = proposal + " " + GenerateRandomString(rand);
                }

                return proposal;
            }

            Console.WriteLine(GenerateRandomProposal(numberOfWords));





        }

    }
}
