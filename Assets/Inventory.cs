using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject pickupButton;
    public GameObject fingerprint;
    public GameObject note;

    void Start()
    {
        Button btn = pickupButton.GetComponent<Button>();
        btn.onClick.AddListener(PickupItem);
    }

    public void PickupItem()
    {
        AddItemToInventory(fingerprint);
        AddItemToInventory(note);
    }

    public void AddItemToInventory(GameObject item)
    {
        item.transform.SetParent(inventoryPanel.transform, false);
        item.SetActive(false);
        item.SetActive(true);
    }
}
