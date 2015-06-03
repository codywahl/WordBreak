using System;
using System.Collections.Generic;

namespace WordBreaker
{
    public class TheWordBreaker
    {
        #region Fields

        private const string noResultsMessage = "Unable to find any of the given words in the string provided.";
        private const string resultsFoundMessage = "The following words were found in the provided string: ";
        private string resultString = "";

        #endregion Fields

        #region Properties

        public string NoResultsMessage { get { return noResultsMessage; } }

        public string ResultsMessage { get { return resultsFoundMessage + resultString; } }

        #endregion Properties

        public Boolean DoesStringContainAnyProvidedWords(string theString, List<string> theWordList)
        {
            if (theWordList.Count == 0 || string.IsNullOrEmpty(theString))
            {
                return false;
            }

            resultString = "";

            foreach (string word in theWordList)
            {
                if (theString.ToLower().Contains(word.ToLower()))
                {
                    resultString += word + " ";
                }
            }

            return !string.IsNullOrEmpty(resultString);
        }
    }
}