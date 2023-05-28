using UnityEngine;

[CreateAssetMenu(fileName ="New Aitem",menuName ="Aitem/Create New Aitem")]

public class Aitem : ScriptableObject
{
   public int id;
   public string itemName;
   public int value;
   public Sprite icon;
}
