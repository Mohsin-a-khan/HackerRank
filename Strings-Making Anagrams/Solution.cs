using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        if(string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
        {
            Console.WriteLine(0);
            return;
        }
        
        Console.WriteLine(GetDeletions(a,b));
           
    }
    
    static Dictionary<char,int> BuildDictionary(string input)
    {
        Dictionary<char,int> countDictionary= new Dictionary<char,int>();
        foreach(char character in input)
        {
           if(!countDictionary.ContainsKey(character))
            {
                countDictionary.Add(character,1);
            }
            else
            {
                countDictionary[character]+=1;
            }
        }
        
        return countDictionary;
    }
    
    static int GetDeletions(string a, string b){
        var aMap=BuildDictionary(a);
        var bMap=BuildDictionary(b);
        int deletions=0;
        int count=0;
        foreach(KeyValuePair<char,int> entry in aMap)
        {
            if(bMap.ContainsKey(entry.Key))
            {
                if(entry.Value>bMap[entry.Key]){
                    count=entry.Value-bMap[entry.Key];
                    //aMap[entry.Key]-=count; 
                    deletions+=count;
                }
                else if(entry.Value<bMap[entry.Key])
                {
                    count=bMap[entry.Key]-entry.Value;                 
                    //bMap[entry.Key]-=count;
                    deletions+=count;
                }       
            }
            else{
                deletions+=aMap[entry.Key];
            }   
        }
        
        foreach(KeyValuePair<char,int> entry in bMap)
        {
            if(!aMap.ContainsKey(entry.Key))
            {
                deletions+=bMap[entry.Key];
            }   
        }
        
        return deletions;
        
    }
}
