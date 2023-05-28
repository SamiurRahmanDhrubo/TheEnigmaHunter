using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Aitem Aitem;

    void Pickup(){
        InventoryManager.Instance.Add(Aitem);
        Destroy(gameObject);
    }

    private void OnMouseDown(){
        Pickup();
    }
}
