using System.Collections.Generic;

namespace PlacesList
{
  public class Place
  {
    private string _placeName;
    private int _id;
    private static List<Place> _places = new List<Place> {};

    public Place (string placeName)
    {
      _placeName = placeName;
      _places.Add(this);
      _id = _places.Count;
    }
    public string GetPlaceName()
    {
      return _placeName;
    }
    public void SetPlaceName(string newPlaceName)
    {
      _placeName = newPlaceName;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Place> GetAll()
    {
      return _places;
    }
    public static Place Find(int searchId){
      return _places[searchId-1];
    }
    public static void ClearAll()
    {
      _places.Clear();
    }
  }
}
