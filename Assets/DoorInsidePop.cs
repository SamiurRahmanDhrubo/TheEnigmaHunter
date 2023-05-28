using UnityEngine;
using UnityEngine.UI;

public class DoorInsidePop : MonoBehaviour
{
    public GameObject button;
    private bool buttonActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")&& !buttonActivated)
        {
            button.SetActive(true);
            buttonActivated = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            button.SetActive(false);
            // Do nothing
        }
    }
}
