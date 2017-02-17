using Xunit;
using System.Collections.Generic;
using RepeatCounterProject;

namespace RepeatCounterProjectTest
{
  public class RepeatCounterTest
  {
    [Fact]
    public void RepeatCounterTest_ForNoMatchesFound_0()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(0, testRepeatCounter.CountRepeats("Hello", "Good Morning"));
    }
  }
}
