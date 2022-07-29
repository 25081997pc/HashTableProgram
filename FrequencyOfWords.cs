using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Demo
{
    public class FrequencyOfWords
    {
        Hashtable MyMapNode = new Hashtable();

        private String[] sentenceSplit;

        public string[] splitString(string sentence)
        {
            return sentence.Split();
        }

        public void countWords(string[] sentenceSplit)
        {
            foreach(String str in sentenceSplit)
            {
                if(MyMapNode.ContainsKey(str))
                {
                    MyMapNode[str] = (int)MyMapNode[str] + 1;
                }
                else
                {
                    MyMapNode.Add(str, 1);
                }
            }
            foreach(DictionaryEntry item in MyMapNode)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
