using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2Interact : MonoBehaviour
{
    public Button level2Button;

    void Start()
    {
        // Disable the button by default
        level2Button.interactable = false;
    }
    // Other methods and code for the scene...

    void update(){
        level2Button.interactable = true;
    }

    // public void MakeButtonInteractable()
    // {
    //     // Make the Level2Button interactable
    //     level2Button.interactable = true;
    // }
}
