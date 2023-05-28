using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForensicUI : MonoBehaviour
{
public Button ForensicButton;
public GameObject FingerPrint;
public GameObject Note;

void Start()
{
   ForensicButton.interactable = false;
}

void CheckCondition()
{
    if (!FingerPrint.activeSelf && !Note.activeSelf)
    {
        ForensicButton.interactable = true;
    }
}
}
