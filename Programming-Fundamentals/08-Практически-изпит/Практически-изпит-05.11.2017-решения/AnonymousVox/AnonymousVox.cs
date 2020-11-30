using System;
using System.Text.RegularExpressions;

class AnonymousVox
{
    static void Main()
    {
        //Read the text
        string text = Console.ReadLine();
        //Read the placeholders
        string[] placeholders = Console.ReadLine().Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

        //Why this pattern? Because we have a sequence of letters, then we have a sequence
        //of ANY ASCII character, then we have another sequence of letters WHICH MUST BE EQUAL TO THE FIRST
        //Well ... How do we do that with Regex? A simple backreference.
        //What's a backreference? Regex Presentation - "\number – matches the value of a numbered capture group"
        //THE VALUE, not the pattern, so its MATCHES THE SAME VALUE THAT THE FIRST GROUP MATCHES
        //Which is exactly what we need for our problem.
        string pattern = @"([a-zA-Z]+)(.+)\1";
        Regex regex = new Regex(pattern);

        //Match them all
        MatchCollection matches = regex.Matches(text);

        //We'll need to follow the placeholders with some index
        int placeholderIndex = 0;

        //Foreach the matches
        foreach (Match match in matches)
        {

            //If the placeholders are more than the values, then we break.
            if (placeholderIndex >= placeholders.Length) break;

            //If not, we REPLACE FIRST, wait ... Why first. Because we need to replace ONLY ONE PLACEHOLDER WITH ONE VALUE.
            text = ReplaceFirst(text, match.Groups[2].Value, placeholders[placeholderIndex++]);
        }

        Console.WriteLine(text);
    }

    //A method for replacing first, works like string.Replace.. But only replaces the first result.
    static string ReplaceFirst(string text, string oldValue, string newValue)
    {
        string substringWithOldValue = text.Substring(0, text.IndexOf(oldValue) + oldValue.Length);

        string substringWithNewValue = substringWithOldValue.Replace(oldValue, newValue);

        return substringWithNewValue + text.Substring(substringWithOldValue.Length);
    }
}

