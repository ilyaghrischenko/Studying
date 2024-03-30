using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    public class DictionaryManager
    {
        private Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        public void AddWord(string word, List<string> translations)
        {
            dictionary[word] = translations;
        }

        public void RemoveWord(string word)
        {
            dictionary.Remove(word);
        }

        public void RemoveTranslations(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                dictionary[word].Clear();
            }
        }

        public void ChangeWord(string oldWord, string newWord)
        {
            if (dictionary.ContainsKey(oldWord))
            {
                var translations = dictionary[oldWord];
                dictionary.Remove(oldWord);
                dictionary[newWord] = translations;
            }
        }

        public void ChangeTranslation(string word, int index, string newTranslation)
        {
            if (dictionary.ContainsKey(word) && index >= 0 && index < dictionary[word].Count)
            {
                dictionary[word][index] = newTranslation;
            }
        }

        public List<string> SearchTranslations(string word)
        {
            if (dictionary.ContainsKey(word))
            {
                return dictionary[word];
            }
            else
            {
                return new List<string>();
            }
        }
    }
}
