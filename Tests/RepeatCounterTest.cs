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

    [Fact]//Spec 3
    public void RepeatCounterTest_ForStringContainsWordOnce_1()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(1, testRepeatCounter.CountRepeats("Hello", "Hello World"));
    }

    [Fact]//Spec 4
    public void RepeatCounterTest_ForStringContainsWordMultiple_NumberOfRepeats()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(2, testRepeatCounter.CountRepeats("Hello", "Hello World. Hello Universe."));
    }

    [Fact]
    public void RepeatCounterTest_ForStringContainsWordCaseDiff_NumberOfRepeats()
    {
      RepeatCounter testRepeatCounter = new RepeatCounter();
      Assert.Equal(3, testRepeatCounter.CountRepeats("hello", "Hello WorldHelloUniverse Hello hahaha "));
    }
  }
}
