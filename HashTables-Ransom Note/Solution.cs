using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');        

        Dictionary<string,int> magazineWordCount=BuildDictionary(magazine);
        Dictionary<string,int> noteWordCount=BuildDictionary(ransom);

		Console.WriteLine(Contains(magazineWordCount, noteWordCount) ? "Yes" : "No");
        
    }
    
    static bool Contains(Dictionary<String, int> word2countMagazine, Dictionary<String, int> word2countNote) 
    {
		foreach (KeyValuePair<string,int> entryNote in word2countNote) 
        {
			if (!word2countMagazine.ContainsKey(entryNote.Key)|| word2countMagazine[entryNote.Key] < entryNote.Value )
            {
				return false;
			}
		}
		return true;
	}
    
    static Dictionary<string,int> BuildDictionary(string[] input)
    {
        Dictionary<string,int> countDictionary= new Dictionary<string,int>();
        foreach(var word in input)
        {
           if(!countDictionary.ContainsKey(word))
            {
                countDictionary.Add(word,1);
            }
            else
            {
                countDictionary[word]+=1;
            }
        }
        
        return countDictionary;
    }
}
