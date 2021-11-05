using System;
using System.Collections.Generic;
using System.Text;

namespace MasterMind.Services
{
    public interface ISecretMatcher
    {
        string getMatch(string input);
        void setSecret(string secret);
    }
}
