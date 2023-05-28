using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoorInside : MonoBehaviour
{   
    public GameObject moovingDoor;
    public float maximumOpening = -20.76f;
    public float maximumClosing = -0.4f;
    public float movementSpeed = 1f;


    bool playerIsHere;
    
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        if(playerIsHere){
               if(moovingDoor.transform.position.z < maximumOpening){
                  moovingDoor.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
               }
        }else{
            if(moovingDoor.transform.position.z > maximumClosing){
                  moovingDoor.transform.Translate(0f, 0f, maximumClosing);
               }
        }
    }
    private void OnTriggerEnter(Collider col){
           if(col.gameObject.tag == "Player"){
            playerIsHere = true;
           }

    }
    private void OnTriggerExit(Collider col){
           if(col.gameObject.tag == "Player"){
            playerIsHere = false;
           }

    }
}