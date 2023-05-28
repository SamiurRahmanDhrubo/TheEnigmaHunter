using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSensorInt : MonoBehaviour
{   
    
    public GameObject InterrogationButton;
    bool playerIsHere;
    
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
     
    }
    void Update()
    {
        if(playerIsHere){
               InterrogationButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
               }
        else{
             InterrogationButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
            }
    }


    
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerIsHere = true;
            
        }   
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player") {
        // Do nothing when the player exits the trigger area
        }
}
    
}