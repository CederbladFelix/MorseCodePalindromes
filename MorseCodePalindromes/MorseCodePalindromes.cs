using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace MorseCodePalindromes
{
    internal class MorseCodePalindromes
    {
        static void Main(string[] args)
        {

            Dictionary<char, string> morseMap = new Dictionary<char, string>();

            morseMap['A'] = ".-";
            morseMap['B'] = "-...";
            morseMap['C'] = "-.-.";
            morseMap['D'] = "-..";
            morseMap['E'] = ".";
            morseMap['F'] = "..-.";
            morseMap['G'] = "--.";
            morseMap['H'] = "....";
            morseMap['I'] = "..";
            morseMap['J'] = ".---";
            morseMap['K'] = "-.-";
            morseMap['L'] = ".-..";
            morseMap['M'] = "--";
            morseMap['N'] = "-.";
            morseMap['O'] = "---";
            morseMap['P'] = ".--.";
            morseMap['Q'] = "--.-";
            morseMap['R'] = ".-.";
            morseMap['S'] = "...";
            morseMap['T'] = "-";
            morseMap['U'] = "..-";
            morseMap['V'] = "...-";
            morseMap['W'] = ".--";
            morseMap['X'] = "-..-";
            morseMap['Y'] = "-.--";
            morseMap['Z'] = "--..";
            morseMap['0'] = "-----";
            morseMap['1'] = ".----";
            morseMap['2'] = "..---";
            morseMap['3'] = "...--";
            morseMap['4'] = "....-";
            morseMap['5'] = ".....";
            morseMap['6'] = "-....";
            morseMap['7'] = "--...";
            morseMap['8'] = "---..";
            morseMap['9'] = "----.";



            string input = Console.ReadLine();
            string trimmedInput = Regex.Replace(input.ToUpper(), "[^A-Z0-9]", "");

            Boolean isPalindrome = true;

            if (string.IsNullOrEmpty(trimmedInput))
            {
                isPalindrome = false;
            }
            else
            {
                StringBuilder morseCode = new StringBuilder();

                foreach (char character in trimmedInput)
                {
                    morseCode.Append(morseMap[character]);
                }

                for (int i = 0; i < morseCode.Length / 2; i++)
                {
                    if (morseCode[i] != morseCode[morseCode.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
            }   

            if (isPalindrome)
            {
                Console.WriteLine("1");
            } 
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
