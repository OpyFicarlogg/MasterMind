using System;
using System.Linq;

namespace MasterMind.Utils
{
    public static class InputUtils
    {

        public static String GetNumericInput(String inputText, int inputLength)
        {
            Boolean end = false;
            String input = "";
            do
            {
                Console.Write(inputText);
                input = Console.ReadLine();
                end = input.All(char.IsDigit) && input.Length.Equals(inputLength);
                if (!end)
                {
                    Console.WriteLine($"Merci de saisir une combinaison de {inputLength} chiffres");
                }
            } while (!end);

            return input;
        }
    }
}
