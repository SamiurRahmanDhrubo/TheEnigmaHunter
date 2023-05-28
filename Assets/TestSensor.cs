using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSensor : MonoBehaviour
{   
    
    public GameObject PickupButton;
   
    bool playerIsHere;
    
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
     
    }
    void Update()
    {
        if(playerIsHere){
               PickupButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
               PickupButton.SetActive(true);
               
               }
        else{
             PickupButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
             PickupButton.SetActive(false);
             
            }
    }


    
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerIsHere = true;
            
        }   
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player") {
            //   Nothing will happen here
        }
}
    
}