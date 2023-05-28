using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainBack : MonoBehaviour
{
    public void BackGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    // public void QuitGame ()
    // // {
    // //     Debug.Log("Game quitted successfully!");
    // //     Application.Quit();
    // // }
}
