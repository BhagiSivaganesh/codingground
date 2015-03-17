using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> lst =new List<int>();
        
        for(int i=0;i<=100;i++){
            lst.Add(i);
        }
     
     IEnumerable<int> qu = from q in lst where q%2 == 1 && q > 50 select q;
     
     /* foreach(int item in qu)
     Console.WriteLine(item); */
     
     if(qu.Contains(65)) 
     {
     Console.WriteLine("YES");
     Console.WriteLine(lst.Find(item => item>65));
     }
     
     else
     { 
     Console.WriteLine("NO");
     }
     
    }
}
