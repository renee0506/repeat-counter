using System;
using System.Collections.Generic;

namespace RepeatCounterProject
{
  public class RepeatCounter
  {
    public int CountRepeats(string wordInput, string stringInput)
    {
      if (wordInput == stringInput)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}
