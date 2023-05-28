using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                hit.collider.gameObject.SendMessage("OnClick");
            }
        }
    }
}
