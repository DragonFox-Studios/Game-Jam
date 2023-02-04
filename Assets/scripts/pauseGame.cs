using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{

    public static bool isGameRunning = true;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isGameRunning = !isGameRunning;

            if (isGameRunning)
            {
                pauseScreen.SetActive(false);
            }
            else
            {
                pauseScreen.SetActive(true);
            }
        }
    }
}