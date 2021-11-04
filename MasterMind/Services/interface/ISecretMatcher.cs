using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Services
{
    interface ISecretMatcher
    {
        string getMatch(string input);
        void setSecret(string secret);
    }
}
