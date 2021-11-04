using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterMind.Services
{
    class SecretMatcherImpl : ISecretMatcher
    {
        private string secret;
        public SecretMatcherImpl(string secret)
        {
            this.secret = secret;
        }

        public string getExactMatch(string input)
        {
            StringBuilder exactMatch = new StringBuilder();

            int i = 0;
            foreach(char c in input)
            {
                if (c.Equals(secret[i]))
                {    
                    exactMatch.Append(c);
                }
                i += 1;
            }

 
            //Autre possibilité avec linq
            /*string match = String.Concat(input
                                        .Select((elt, index) => new { elt, index })
                                        .Where(obj => obj.elt.Equals(secret[obj.index]))
                                        .Select(obj => obj.elt)
                                  );*/


            int wrongPosition = input.Count(elt => !secret.IndexOf(elt).Equals(-1) && exactMatch.ToString().IndexOf(elt).Equals(-1));

            return convertValueToString(exactMatch.Length,"+")+convertValueToString(wrongPosition, "-");
        }


        private String convertValueToString(int value, String toConvert) 
        {
            Console.WriteLine($"value = {value} || toConvert = {toConvert}");
            StringBuilder result = new StringBuilder();
            for(int i = 0; i < value;i++){
                result.Append(toConvert);
            }

            return result.ToString();
        }

        public void setSecret(string secret)
        {
            this.secret = secret;
        }
    }
}
