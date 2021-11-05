using MasterMind.Services;
using System;
using MasterMind.Utils;
using CommandLine;
using MasterMind.Configurations;

namespace MasterMind
{
    static class Program
    {

        static void Main(string[] args)
        {
            int lengthOfSecret = 0;
            int? round = null;

            Parser.Default.ParseArguments<CommandLineOptions>(args)
                   .WithParsed<CommandLineOptions>(o =>
                   {
                       lengthOfSecret = o.SecretLength;
                       round = o.Round;
                   }).WithNotParsed(errors => {
                       //Exit app if error
                       Environment.Exit(0);
                   });

            Console.WriteLine($"Le jeu a été lancé avec un secret de taille {lengthOfSecret} {(round != null ? $"Et {round} rounds" : "")}");


            ISecretMatcher matcher = new SecretMatcherImpl();
            Boolean play = true;

            //Set the secret from user input and hidden
            String secret = InputUtils.GetNumericInput("Entrer un secret: ", lengthOfSecret,true);
            matcher.setSecret(secret);


            int i = 1;
            while (play)
            {
                String userInput = InputUtils.GetNumericInput("Entrer une combinaison: ", lengthOfSecret);

                //If the secret is equals, 
                if (secret.Equals(userInput))
                {
                    play = false;
                    Console.WriteLine(matcher.getMatch(userInput));
                    Console.WriteLine($"Bravo ! Le secret est {secret}");
                }
                else
                {
                    Console.WriteLine(matcher.getMatch(userInput));
                    if (round != null)
                    {
                        if (round.Equals(i))
                        {
                            play = false;
                            Console.WriteLine($"Vous avez perdu ! Le secret est {secret}");
                        }
                        else
                        {
                            int remainRound = (int)(round - i);
                            Console.WriteLine($"Il vous reste {remainRound} essai{(!remainRound.Equals(1) ? "s" : "")  }");
                        }

                    }

                }
                i++;

            }

        }      
    }
}
