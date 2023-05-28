using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionManager : MonoBehaviour
{
    public Vector3 defaultStartingPosition = new Vector3(-117.980003f, 4.5f, -10.8199997f);

    private void Start()
    {
        LoadPosition();
    }

    public void LoadPosition()
    {
        float savedPositionX = PlayerPrefs.GetFloat("savedPositionX", defaultStartingPosition.x);
        float savedPositionY = PlayerPrefs.GetFloat("savedPositionY", defaultStartingPosition.y);
        float savedPositionZ = PlayerPrefs.GetFloat("savedPositionZ", defaultStartingPosition.z);
        transform.position = new Vector3(savedPositionX, savedPositionY, savedPositionZ);
    }

    public void SavePosition()
{
    PlayerPrefs.SetFloat("savedPositionX", transform.position.x);
    PlayerPrefs.SetFloat("savedPositionY", transform.position.y);
    PlayerPrefs.SetFloat("savedPositionZ", transform.position.z);
}


    public void ResetPosition()
    {
        PlayerPrefs.DeleteKey("savedPositionX");
        PlayerPrefs.DeleteKey("savedPositionY");
        PlayerPrefs.DeleteKey("savedPositionZ");
        transform.position = defaultStartingPosition;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
