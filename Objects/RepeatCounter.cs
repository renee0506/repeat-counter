using System;
using System.Collections.Generic;

namespace RepeatCounterProject
{
  public class RepeatCounter
  {
    public int CountRepeats(string wordInput, string stringInput)
    {
      //Convert Inputs to Char Array
      char[] stringInputArray = stringInput.ToCharArray();
      char[] wordInputArray = wordInput.ToCharArray();
      int count = 0;

      for (int i = 0; i < stringInputArray.Length; i++)
      {
        if (stringInputArray[i] == wordInputArray[0])
        {
          int j = 0;
          while (j < wordInputArray.Length)
          {
            if (stringInputArray[i+j] == wordInputArray[j])
            {
              if (j == wordInputArray.Length -1)
              {
                count+=1;
              }
              j++;
            }
          }
        }
      }

      return count;
      // if (stringInput.Contains(wordInput))
      // {
      //   return 1;
      // }
      // else
      // {
      //   return 0;
      // }
    }
  }
}
