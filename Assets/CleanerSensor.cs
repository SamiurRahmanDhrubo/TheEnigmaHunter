using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerSensor : MonoBehaviour
{
    public GameObject ForensicButton;
    bool playerIsHere;
    
    // Start is called before the first frame update
    void Start()
    {
        // playerIsHere = false;
        
     
    }
    void Update()
    {
        if(playerIsHere){
               ForensicButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
               }
        else{
             ForensicButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
            }
    }


    
    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerIsHere = true;
            
        }   
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player") {
            //    noting will happen playerIsHere
        }
}
}
