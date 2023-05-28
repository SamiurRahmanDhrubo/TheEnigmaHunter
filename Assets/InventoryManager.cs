using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager Instance;
   public List<Aitem> Aitems = new List<Aitem>();

   public Transform ItemContent;
   public GameObject InventoryItem;

   private void Awake(){
    Instance =this;
   }
   public void Add(Aitem aitem){
    Aitems.Add(aitem);
   }
   public void Remove(Aitem aitem){
    Aitems.Remove(aitem);
   }

   public void ListItems(){
    foreach (Transform aitem in ItemContent)
    {
        Destroy(aitem.gameObject);
    }
    foreach (var aitem in Aitems)
    {
       GameObject obj = Instantiate(InventoryItem,ItemContent);
       var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
       var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

       itemName.text = aitem.itemName;
       itemIcon.sprite = aitem.icon; 
    }
   }
}
