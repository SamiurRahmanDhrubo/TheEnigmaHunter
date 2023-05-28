using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectPicker : MonoBehaviour
{
    public GameObject FingerPrint;
    public GameObject Note;
    

    public void ClickObjects()
    {
        FingerPrint.GetComponent<IPointerClickHandler>().OnPointerClick(null);
        Note.GetComponent<IPointerClickHandler>().OnPointerClick(null);
       
    }
}
