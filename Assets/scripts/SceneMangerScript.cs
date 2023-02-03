using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMangerScript : MonoBehaviour
{
    
    public void StartGame()
    {
        Debug.Log("Starting game");
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {

    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
