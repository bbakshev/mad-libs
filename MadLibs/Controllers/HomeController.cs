using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/yourmadlib")]
    public ActionResult YourMadLib(string name, string adjective1, string verb1, string sillyword, string noun1, string pluralnoun, string verb2, string noun2, string noun3, string verb3, string adjective2)
    {
      MadLibsVariable myMadLibsVariable = new MadLibsVariable();
      myMadLibsVariable.Name = name;
      myMadLibsVariable.Adjective1 = adjective1;
      myMadLibsVariable.Verb1 = verb1;
      myMadLibsVariable.SillyWord = sillyword;
      myMadLibsVariable.Noun1 = noun1;
      myMadLibsVariable.PluralNoun = pluralnoun;
      myMadLibsVariable.Verb2 = verb2;
      myMadLibsVariable.Noun2 = noun2;
      myMadLibsVariable.Noun3 = noun3;
      myMadLibsVariable.Verb3 = verb3;
      myMadLibsVariable.Adjective2 = adjective2;
      return View(myMadLibsVariable);
    }
  }
}