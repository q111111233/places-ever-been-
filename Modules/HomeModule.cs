using Nancy;
using System.Collections.Generic;
using PlacesList;

namespace PlacesList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/new"] = _ =>{
        return View["place_form.cshtml"];
      };
      Post["/places"] = _ =>{
        Place newPlace = new Place (Request.Form["new-place"]);
        List<Place> allPlaces = Place.GetAll();
        return View["places.cshtml", allPlaces];
      };
      Get["/places/{id}"] = parameters => {
        Place place = Place.Find(parameters.id);
        return View["/place.cshtml", place];
      };
    }
  }
}
