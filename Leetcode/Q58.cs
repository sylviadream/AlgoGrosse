using System;

namespace Leetcode
{
    class    Q58LengthOfLastWord
    {

    public static Boolean Q58_LengthOfLastWord_Test()
{
    Q58LengthOfLastWord qstring = new  Q58LengthOfLastWord();
    try{
           Console.WriteLine(qstring.Q58_LengthOfLastWord("a"));
            Console.WriteLine(qstring.Q58_LengthOfLastWord("aaa"));
            return true;
    }
    catch
    {
        return false;
    }
}

    public  int Q58_LengthOfLastWord(string s)
    {
      if (s.Length != 0)
        {
        char c = ' ' ; 
         for (int i = 0; i<s.Length; i++)
         {
             c = s[s.Length-i-1];             
            if  ( c != ' ' )
            {      
               int j;
                for (j= 0 ; j<s.Length-j-i; j++)
                {
                 char d= s[s.Length-j-i-1]; 
                    
                         if  (d == ' ')
                               {
                                    return  j;
                                }   
                }
                return j;
            }
      }
}
                  return 0;
}
}


}
