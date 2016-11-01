using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int p = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < p; a0++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine(isPrime(n)?"Prime":"Not prime");
        }
           
    }
    
    static bool isPrime(int n){
        if(n<2 || n>2000000000){
            return false;
        } 
        
        for(int d=2;d*d<=n;d++){
                if(n%d==0){
                    return false;
                }
            }
        return true;
    }
    }
    
