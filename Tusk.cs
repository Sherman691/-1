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

            string[] ReadText (string text)
            {
                Console.WriteLine(text);
                string readText = Console.ReadLine();
                string[] offerArray = readText.Split (',');
                return offerArray;
            }
            string[] test = { "text", "dasdas", "23", "1", "234", "dsa", "2345" }; //ReadText("Введите набор слов через запятую: ");
            int count = 0;
            char quote = '"';
            int countForSmallArray = 0;
            foreach(string offer in test)
            {
                if (offer.Length <= 3)
                {
                    count++;
                }
            }
            string[] array = new string[count];
           
                foreach(var offer in test)
                {
                    if (offer.Length < 4)
                    {
                        array[countForSmallArray] = offer;
                        countForSmallArray++;
                    }
                }
            string output = "[";
            for (int i = 0; i < array.Length; i++)
            {
                output += "\"" + array[i] + "\"";
                if (i < array.Length - 1)
                {
                    output += ", ";
                }
            }
            output += "]";

            Console.WriteLine(output);
            

            





        }

    }
}
