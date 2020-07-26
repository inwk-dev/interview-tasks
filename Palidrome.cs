using System;
using System.Collections.Generic;
using System.Linq;

public class Palidrome
{
    private static string Reverse(string s)
    {
        //Initalize the string as a Char Array
        char[] charArray = s.ToCharArray();

        //Reverse the string
        Array.Reverse(charArray);

        return new string(charArray);
    }

    private static string RemoveWhiteSpaces(string input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsWhiteSpace(input[i]))
            {
                input = input.Remove(i, 1);
            }
        }
        return input;
    }

    public bool isPalidromeCaseSensitive(string word)
    {
        //Reverse the string, convert it in lower case and trim the whitespaces except the one in between the
        //words
        string reversed = Reverse(word).ToLower().Trim();

        //Comparaison
        if (word == reversed)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    public bool isPalidromCaseInSensitive(string word)
    {

        //Reverse the input string
        string reversed = Reverse(word);
        
        //remove white spaces from the input word
        string com2 = RemoveWhiteSpaces(word);

        //remove white spaces from the reversed input
        string comp = RemoveWhiteSpaces(reversed);

        //Comparaison
        if (comp == com2)
        {
            return true;

        }
        else
        {
            return false;
        }
    }
}