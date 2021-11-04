using MasterMind.Extensions;
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

        public string getMatch(string input)
        {
            StringBuilder exactMatch = new StringBuilder();

            //Get list of number at the exact position
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

            //Get number of element at the wrong position
            //TODO: Correction du cas 1322  avec par exemple 1223 qui va retourner: ++- à la place de ++--
            int wrongPosition = input.Count(elt => !secret.IndexOf(elt).Equals(-1) && exactMatch.ToString().IndexOf(elt).Equals(-1));

            return exactMatch.Length.convertValueToString("+")+ wrongPosition.convertValueToString("-");
        }


        public void setSecret(string secret)
        {
            this.secret = secret;
        }
    }
}
