using Xunit;
using System.Collections.Generic;
using RepeatCounterProject;

namespace RepeatCounterProjectTest
{
  public class RepeatCounterTest
  {
    [Fact]//Spec 1
    public void RepeatCounterTest_ForNoMatchesFound_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(0, testRepeatCounter.CountRepeats("Hello", "Good Morning"));
    }

    [Fact]//Spec 2
    public void RepeatCounterTest_ForWordAndStringExactlySame_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.CountRepeats("Hello", "Hello"));
    }
  }
}
