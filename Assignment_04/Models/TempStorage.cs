using System;
using System.Collections.Generic;

namespace Assignment_04.Models
{
    public class TempStorage
    {
        //suggestions is a list of type Suggestions
        private static List<Suggestions> suggestions = new List<Suggestions>();

        //An IEnumerable of type Suggestions that is a lambda function that returns the list of suggestions
        public static IEnumerable<Suggestions> Suggestions => suggestions;

        //A public method that adds a suggestion to the private list of suggestions
        public static void AddSuggestion(Suggestions suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
