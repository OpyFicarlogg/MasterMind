using MasterMind.Services;
using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            SecretMatcherImpl matcher = new SecretMatcherImpl("1234");

            Console.WriteLine(matcher.getExactMatch("1243"));
        }
    }
}
