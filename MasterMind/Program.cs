using MasterMind.Services;
using System.Linq;
using System;
using MasterMind.Utils;

namespace MasterMind
{
    class Program
    {    

        static void Main(string[] args)
        {

            //TODO: as parameter
            int nbOfNumber = 4;

            Boolean play = true;

            //TODO: Hide user input in console

            String secret = InputUtils.GetNumericInput("Enter secret: ", nbOfNumber);
            SecretMatcherImpl matcher = new SecretMatcherImpl(secret);

            //TODO: Add number of possibility
            while (play)
            {
                String userInput = InputUtils.GetNumericInput("Entrer une combinaison: ", nbOfNumber);

                if (secret.Equals(userInput))
                {
                    play = false;
                }
                else
                {
                    Console.WriteLine(matcher.getMatch(userInput));
                }
                
            }
           

            Console.WriteLine($"Bravo ! La combinaison est {secret}");
        }

        
        
    }
}
