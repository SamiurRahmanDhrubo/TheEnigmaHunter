using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupButtonScript : MonoBehaviour
{
     
public GameObject fingerPrint;
public GameObject note;
public GameObject inventoryPanel;

public void PickUpClues()
{
    Instantiate(fingerPrint, inventoryPanel.transform);
    Instantiate(note, inventoryPanel.transform);
}

}
