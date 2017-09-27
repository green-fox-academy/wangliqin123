using System.Collections.Generic;

namespace CountLetters
{
    public class Count
    {
        public Dictionary<char, int> DictionaryMaker(string word)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            word.ToCharArray();
           
            foreach (var letter in word)
            {
                if (!map.ContainsKey(letter))
                {
                    map.Add(letter, +1);
                }
                else
                {
                    map[letter]++;
                }  
            }
            return map;
        }
    }
}