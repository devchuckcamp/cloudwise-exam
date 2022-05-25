using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CouncilWise
{
    public static class Helper
    {
        const decimal TaxRate = 0.1m;
        public  const decimal  inclusiveTaxMultiplier = 11;
        public const decimal  exclusiveTaxMultiplier = 0.1m;
        public static decimal CurrencyRound(this decimal value)
        {
            return Math.Round(value, 2);
        }

        public static bool isPpalindrome(string word)
        { 
            var reversedWord = new string(word.Reverse().ToArray());
            var palindrome = word == reversedWord;
            return palindrome;
        }
        
    }
}
