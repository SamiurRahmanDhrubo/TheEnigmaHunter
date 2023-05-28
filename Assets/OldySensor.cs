using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldySensor : MonoBehaviour
{
    public GameObject ReportButton;
    bool playerIsHere;

    void Start()
    {
        playerIsHere = false;
       
     
    }

    void Update()
    {
        if(playerIsHere){
               ReportButton.GetComponent<UnityEngine.UI.Button>().interactable = true;
               
               }
        else{
             ReportButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
             
            }
    }

    private void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Player") {
            playerIsHere = true;
            
            
        }   
    }
    private void OnTriggerExit(Collider col) {
        if (col.gameObject.tag == "Player") {
            //    Nothing will be happen
        }
    }
}
