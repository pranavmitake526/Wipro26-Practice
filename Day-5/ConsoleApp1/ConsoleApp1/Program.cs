using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Input 1: Main String 
            string mainString = GetInput("");

            // Input 2: Sub String  
            string substring = GetInput("");

            // Input 3: Character to be replaced 
            char charToReplace = GetInput("")[0];

            // Input 4: Character to be replaced with 
            char replacementChar = GetInput("")[0];

            bool substringExists = CheckSubstringExists(mainString, substring);
            string replacedString = ReplaceCharacter(mainString, charToReplace, replacementChar);
            string caseSwapped = SwapCase(mainString);
            string noSpaces = RemoveWhitespace(mainString);
            Dictionary<char, int> letterCount = CountLetters(mainString);

            Console.WriteLine($"Substring Exists: {(substringExists ? "Yes" : "No")}");
            Console.WriteLine($"Replaced: {replacedString}");
            Console.WriteLine($"Case Swapped: {caseSwapped}");
            Console.WriteLine($"No Spaces: {noSpaces}");
            Console.WriteLine($"Letter Count: {string.Join(", ", letterCount.Select(kvp => $"{kvp.Key}: {kvp.Value}"))}");
        }

        static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static bool CheckSubstringExists(string main, string sub)
        {
            return main.Contains(sub);
        }

        static string ReplaceCharacter(string input, char oldChar, char newChar)
        {
            return input.Replace(oldChar, newChar);
        }

        static string SwapCase(string input)
        {
            char[] chars = input.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                    chars[i] = char.ToLower(chars[i]);
                else if (char.IsLower(chars[i]))
                    chars[i] = char.ToUpper(chars[i]);
            }

            return new string(chars);
        }

        static string RemoveWhitespace(string input)
        {
            return new string(input.Where(c => !char.IsWhiteSpace(c)).ToArray());
        }

        static Dictionary<char, int> CountLetters(string input)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (counts.ContainsKey(c))
                        counts[c]++;
                    else
                        counts[c] = 1;
                }
            }

            return counts;
        }
    } 
}
