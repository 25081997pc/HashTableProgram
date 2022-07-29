using HashTable_Demo;
using System.Collections;

namespace HashTable_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Hash Table Program");
            Console.WriteLine("Hash Table Demo");
            FrequencyOfWords frequency = new FrequencyOfWords();
            Console.WriteLine("Frequency of Words : ");
            string s = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] sentenceSplit = frequency.splitString(s);
            frequency.countWords(sentenceSplit);
        }
    }
}
