using System.Collections.Generic;

namespace KnightsOfNi.Objects
{
  public class Knight
  {
    private string _sirName;
    private string _hut;
    private string _weapon;
    private static List<Knight> _instances = new List<Knight> {};
    private int _id;

    public Knight(string sirName, string hut, string weapon)
    {
      _sirName = sirName;
      _hut = hut;
      _weapon = weapon;
      _instances.Add(this); // Save method
      _id = _instances.Count;
    }

    public string GetName()
    {
      return "Sir " +  _sirName;
    }
    public void SetName(string newSirName)
    {
      _sirName = newSirName;
    }
    public string GetHut()
    {
      return "who dwells in a " + _hut;
    }
    public void SetHut(string newHut)
    {
      _hut = newHut;
    }
    public string GetWeapon()
    {
      return "and uses a rusty dank " + _weapon + " as a method to fight off injustice";
    }
    public void SetWeapon(string newWeapon)
    {
      _weapon = newWeapon;
    }

    public static List<Knight> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }
    public static Knight Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}
