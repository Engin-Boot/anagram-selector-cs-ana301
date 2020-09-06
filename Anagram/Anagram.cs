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
            
            Arrays.Sort(wordArr1);
            Arrays.Sort(wordArr2);
            
            string wordOne=new string(wordArr1);
            string wordSec=new string(wordArr2);
            
            if(wordOne.Equals(wordSec))
                return true;
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            //Insert the correct implementation here
            
            List<String> ans=new List<>();
            for(int i=0;i<candidates.Length();i++){
                if(WordPairIsAnagram(word,candidates[i]))
                    ans.add(candidates[i]);
            }
            
            return ans;
        }
    }
}
