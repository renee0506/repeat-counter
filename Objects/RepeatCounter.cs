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

      int i = 0;
      while (i < stringInputArray.Length)
      {
        if (stringInputArray[i] == wordInputArray[0])
        {
          string slice = stringInput.Substring(i, wordInput.Length);
          if (slice == wordInput)
          {
            count+=1;
            i = i + wordInput.Length-1;
          }
        }
        i++;
      }
      return count;
    }
  }
}
