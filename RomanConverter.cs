using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanApp
{
    public interface IRomanNumeralGenerator
    {
        string Generate(int number);
    }

    public class RomanConverter : IRomanNumeralGenerator
    {
        private List<KeyValuePair<int, string>> romanList = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, "I"),
                new KeyValuePair<int, string>(5, "V"),
                new KeyValuePair<int, string>(10, "X"),
                new KeyValuePair<int, string>(50, "L"),
                new KeyValuePair<int, string>(100, "C"),
                new KeyValuePair<int, string>(500, "D"),
                new KeyValuePair<int, string>(1000, "M")
            };

        private string Spam(string symbol, int count)
        {
            var result = "";

            for (int i = 0; i < count; i++)
            {
                result += symbol;
            }

            return result; 
        }

        private string GetMiddle(int decimalPlace)
        {
            switch (decimalPlace)
            {
                case 1: return "V";
                case 2: return "L";
                case 3: return "D";

                default: return "";
            }
        }

        private string GetStart(int decimalPlace)
        {
            switch (decimalPlace)
            {
                case 1: return "I";
                case 2: return "X";
                case 3: return "C";
                case 4: return "M";
                
                default: return "";
            }
        }

        public string Generate(int number)
        {
            var decimalPlace = number.ToString().Length;
            var result = "";

            foreach (var num in number.ToString())
            {
                var temp = int.Parse(num.ToString());
                var startSymbol = GetStart(decimalPlace);
                var middleSymbol = GetMiddle(decimalPlace);

                if (temp >= 1 && temp <= 3)
                {
                    result += Spam(startSymbol, temp);
                }
                else if (temp == 4)
                {
                    result += startSymbol + middleSymbol;
                }
                else if (temp >= 5 && temp <= 8)
                {
                    if (temp == 5)
                        result += middleSymbol;
                    else
                    {
                        var middleValue = 5;

                        for (int i = 0; i < decimalPlace - 1; i++)
                            middleValue *= 10;

                        result += middleSymbol + Spam(startSymbol, temp - middleValue);
                    }
                }
                else
                {
                    result += startSymbol + GetStart(decimalPlace + 1);
                }

                decimalPlace -= 1;
            }

            return result;
        }
    }
}
