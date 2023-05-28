using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GaminiSensor : MonoBehaviour
{
    public GameObject InterrogationButton;
    
    public GameObject ReportButton;
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
               
               ReportButton.SetActive(true);
               
               }
        else{
             InterrogationButton.GetComponent<UnityEngine.UI.Button>().interactable = false;
             
             ReportButton.SetActive(false);
             
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
