using Nancy;
using KnightsOfNi.Objects;
using System.Collections.Generic;

namespace KnightsOfNi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/knights/new"] = _ => {
        return View["knights_form.cshtml"];
      };
      Get["/knights"] = _ => {
        List<Knight> allKnights = Knight.GetAll();
        return View["knights.cshtml",allKnights];
      };
      Post["/knights"] = _ => {
        Knight newKnight = new Knight (Request.Form["new-name"], Request.Form["new-hut"], Request.Form["new-weapon"]);
        List<Knight> allKnights = Knight.GetAll();
        return View["knights.cshtml", allKnights];
      };
      Get["/knights/{id}"] = parameters => {
        Knight knight = Knight.Find(parameters.id);
        return View["/knight.cshtml", knight];
      };
    }
  }
}
