using System;
using System.Collections.Generic;

namespace RepeatCounterProject
{
  public class RepeatCounter
  {
    public int CountRepeats(string wordInput, string stringInput)
    {
      int count = 0;
      int i = 0;
      //set the initial value of counter and loop tracker i
      while (i < stringInput.Length)
      {
        if (stringInput[i] == wordInput[0])//detect the beginning char of word input
        {
          string slice = stringInput.Substring(i, wordInput.Length);//slice the string input from index i to i+the length of word input
          if (slice == wordInput)//if index i is the beginning of the wordinput, the slice should be same as word input
          {
            count+=1;
            i = i + wordInput.Length-1;//jump to the end of the word and start the new searching from there (need to minus 1 here because of the i++ outside the if statement)
          }
        }
        i++;//if not match countinue to next char
      }

      return count;
    }
  }
}
