using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanApp.Core
{
    public interface IRomanNumeralGenerator
    {
        string Generate(int number);
    }

    public class RomanConverter : IRomanNumeralGenerator
    {
        // Function to spam 'symbol' 'count' times -> III or XX
        private string Spam(string symbol, int count)
        {
            var result = "";

            for (int i = 0; i < count; i++)
                result += symbol;

            return result; 
        }

        // Function to get the middle symbol in the specific decimal place -> 1-10 = 5(V) or 10-100 = 50(L)
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

        // Function to get the start symbol in the specific decimal place -> 1-10 = 1(I) or 10-100 = 10(X)
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

        // Function to convert int number to string roman
        public string Generate(int number)
        {
            // First checking our range
            if (number >= 1 && number <= 3999)
            {
                // Getting number length (current number decimal place)
                var decimalPlace = number.ToString().Length;
                var result = "";

                // Going through each individual number
                foreach (var num in number.ToString())
                {
                    var temp = int.Parse(num.ToString());
                    // Getting start symbol for current number
                    var startSymbol = GetStart(decimalPlace);
                    // Getting middle symbol for current number
                    var middleSymbol = GetMiddle(decimalPlace);

                    // Checking number in range to determine what symbol to add
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
                            // If value is higher than 5 (e.g 7)
                            // then we need to add middle (e.g 5) and spam start symbol (7-5 = 2) 2 times
                            // e.g V + II
                            result += middleSymbol + Spam(startSymbol, temp - 5);
                    }
                    else if (temp == 9)
                    {
                        result += startSymbol + GetStart(decimalPlace + 1);
                    }
                    else if (temp == 10)
                    {
                        result += GetStart(decimalPlace);
                    }

                    decimalPlace -= 1;
                }

                return result;
            }
            else
                return "Invalid number range (1-3999)";
        }
    }
}
