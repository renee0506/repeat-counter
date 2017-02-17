using Nancy;
using System;
using System.Collections.Generic;
using RepeatCounterProject;

namespace RepeatCounterModule
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Get["/result"] = _ => {
        string WordInput = Request.Query["word-input"];
        string StringInput = Request.Query["string-input"];
        RepeatCounter newRepeatCounter = new RepeatCounter();
        int Count = newRepeatCounter.CountRepeats(WordInput, StringInput);
        return View["result.cshtml", Count];
      };
    }
  }
}
