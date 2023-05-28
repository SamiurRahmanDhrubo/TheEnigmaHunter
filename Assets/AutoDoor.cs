using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDoor : MonoBehaviour
{   
    public GameObject moovingDoor;
    public GameObject oldNPC;
    public GameObject newCharacter;
    private Vector3 initialPosition;
    public float maximumOpening = -20.76f;
    public float maximumClosing = -0.4f;
    public float movementSpeed = 1f;

    bool playerIsHere;
    
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        initialPosition = moovingDoor.transform.position;
     
    }

    // Update is called once per frame
    void Update()
    {
        if(playerIsHere){
               if(moovingDoor.transform.position.z < maximumOpening){
                  moovingDoor.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
               }
        }else{
            if(moovingDoor.transform.position.z > initialPosition.z){
                  moovingDoor.transform.Translate(0f, 0f, -(movementSpeed * Time.deltaTime));
               }
        }
    }
    private void OnTriggerEnter(Collider col){
           if(col.gameObject.tag == "Player"){
            // Disable the old NPC
        oldNPC.SetActive(false);
        
        // Enable the new character
        newCharacter.SetActive(true);

        playerIsHere = true;
            
        }

    }
    private void OnTriggerExit(Collider col){
           if(col.gameObject.tag == "Player"){
            // Enable the old NPC
        oldNPC.SetActive(true);

        // Disable the new character
        newCharacter.SetActive(false);
        playerIsHere = false;
        }

    }
}
