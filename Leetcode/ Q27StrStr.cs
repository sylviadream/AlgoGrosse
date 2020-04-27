using System;

namespace Leetcode
{
    class   Q27StrStr
    {

    public static Boolean Q27_StrStr_Test()
{
    Q27StrStr qstring = new  Q27StrStr();
    try{
           Console.WriteLine(qstring.Q27_StrStr("a","a"));
            Console.WriteLine(qstring.Q27_StrStr("aaa","aaa"));
            return true;
    }
    catch
    {
        return false;
    }
}

    public  int Q27_StrStr(string haystack, string needle)
    {
        int j = 0;
            if (needle.Length == 0 )
            {
                return 0;
            }
        foreach  (char c in haystack )
        {         
            if (c == needle[0])
            {
                int i = 0; 
                int temp=haystack.Length - j ;
              do  
                {
                    if   ( haystack[i+j] != needle[i])
                    {
                        break;
                    }
                    i++;
                 }while (  i<needle.Length && needle.Length< temp +1);
               if  (  i == needle.Length)
               {
                   return j;
               }
            }
               j++;
        }
        return -1;        
    }
}
}
