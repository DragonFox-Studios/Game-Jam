using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGame : MonoBehaviour
{


    public GameObject cycleDown;
    public GameObject cycleUp;
    public GameObject buttonUp;
    public GameObject buttonDown;
    public GameObject buttonLeft;
    public GameObject buttonRight;

    



    public static bool isGameRunning = true;
    public GameObject pauseScreen;

    // Start is called before the first frame update
    void Start()
    {
        terminalRadio.cycleDown = cycleDown;
        terminalRadio.cycleUp = cycleUp;
        terminalRadio.buttonUp = buttonUp;
        terminalRadio.buttonDown = buttonDown;
        terminalRadio.buttonLeft = buttonLeft;
        terminalRadio.buttonRight = buttonRight;

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
