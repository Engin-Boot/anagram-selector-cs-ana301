using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            //Insert the correct implementation here
            char[] wordArr1=word1.ToLower().ToCharArray();
            char[] wordArr2=word2.ToLower().ToCharArray();
            
            Array.Sort(wordArr1);
            Array.Sort(wordArr2);
            
            string wordOne=new string(wordArr1);
            string wordSec=new string(wordArr2);
            
            if(wordOne.Equals(wordSec))
                return true;
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            
            List<string> ans=new List<string>();
            for(int i=0;i<candidates.Count();i++){
                if(WordPairIsAnagram(word,candidates[i]))
                    ans.Add(candidates[i]);
            }
            
            return ans;
        }
    }
}
