using UnityEngine;

public class Saver : MonoBehaviour
{
    private Vector3 defaultPosition = new Vector3(-117.980003f, 4.5f, -10.8199997f);

    private void Start()
{
    LoadPlayerPosition();
    if (transform.position == Vector3.zero)
    {
        transform.position = defaultPosition;
    }
}


    private void OnApplicationQuit()
    {
        SavePlayerPosition();
    }

    private void SavePlayerPosition()
    {
        Vector3 playerPosition = transform.position;

        PlayerPrefs.SetFloat("PlayerXPosition", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerYPosition", playerPosition.y);
        PlayerPrefs.SetFloat("PlayerZPosition", playerPosition.z);

        Debug.Log("Player position saved.");
    }

    private void LoadPlayerPosition()
    {
        float playerXPosition = PlayerPrefs.GetFloat("PlayerXPosition");
        float playerYPosition = PlayerPrefs.GetFloat("PlayerYPosition");
        float playerZPosition = PlayerPrefs.GetFloat("PlayerZPosition");

        transform.position = new Vector3(playerXPosition, playerYPosition, playerZPosition);

        Debug.Log("Player position loaded.");
    }

    public void ResetPlayerPosition()
    {
        PlayerPrefs.DeleteKey("PlayerXPosition");
        PlayerPrefs.DeleteKey("PlayerYPosition");
        PlayerPrefs.DeleteKey("PlayerZPosition");

        transform.position = defaultPosition;

        Debug.Log("Player position reset.");
    }
}
