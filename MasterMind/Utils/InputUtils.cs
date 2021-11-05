using System;
using System.Linq;
using System.Text;

namespace MasterMind.Utils
{
    public static class InputUtils
    {

        public static String GetNumericInput(String inputText, int inputLength, Boolean hidden = false)
        {
            Boolean end = false;
            String input = "";
            do
            {
                Console.Write(inputText);
                input = hidden? HideCharacter() : Console.ReadLine();
                end = input.All(char.IsDigit) && input.Length.Equals(inputLength);
                if (!end)
                {
                    Console.WriteLine($"Merci de saisir une combinaison de {inputLength} chiffres");
                }
            } while (!end);

            return input;
        }

        public static string HideCharacter()
        {
            ConsoleKeyInfo key;
            StringBuilder code = new StringBuilder();
            do
            {
                key = Console.ReadKey(true);

                if (Char.IsNumber(key.KeyChar))
                {
                    Console.Write("*");
                    code.Append(key.KeyChar);
                }
                
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine("");

            return code.ToString();

        }


    }
}
