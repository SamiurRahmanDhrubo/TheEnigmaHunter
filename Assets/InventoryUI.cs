using UnityEngine;

/* This object updates the inventory UI. */

public class InventoryUI : MonoBehaviour {

	
	public GameObject inventoryUI;	// The entire UI

	

	void Start () {
		
	}
	
	void Update () {
		// Check to see if we should open/close the inventory
		if (Input.GetButtonDown("InventoryButton"))
		{
			inventoryUI.SetActive(!inventoryUI.activeSelf);
		}
	}
}