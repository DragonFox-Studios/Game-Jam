using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void RestartGame()
    {
        pauseGame.isGameRunning = !pauseGame.isGameRunning;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }

    public void MainMenu()
    {
        pauseGame.isGameRunning = !pauseGame.isGameRunning;
        SceneManager.LoadScene("StartMenu");

    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
