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
        if (WordInput == ""||StringInput == "")
        {
          return View["input_invalid.cshtml"];
        }
        else
        {
          Dictionary<string, string> Model = new Dictionary<string, string>(){{"WordInput", WordInput}, {"StringInput", StringInput}};
          RepeatCounter newRepeatCounter = new RepeatCounter();
          int Count = newRepeatCounter.CountRepeats(WordInput, StringInput);
          string CountString = Count.ToString();
          Model.Add("Count", CountString);
          return View["result.cshtml", Model];
        }

      };
    }
  }
}
