using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Services
{
    interface ISecretMatcher
    {
        string getExactMatch(string input);
        void setSecret(string secret);
    }
}
