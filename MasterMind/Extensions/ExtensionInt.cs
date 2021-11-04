using System;
using System.Text;

namespace MasterMind.Extensions
{
    public static class ExtensionInt
    {
        public static String convertValueToString(this int value, string toConvert)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < value; i++)
            {
                result.Append(toConvert);
            }

            return result.ToString();
        }
    }
}
