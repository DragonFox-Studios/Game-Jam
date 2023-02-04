using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalRadio : MonoBehaviour
{

    private int targetNumber = 0;

    public int  moveAmount = 1;

    public bool isX = true;

    public List<GameObject> targetWalls = new List<GameObject>();

    private wallMovement targetScript;


    public GameObject buttonUp;
    public GameObject buttonDown;
    public GameObject buttonLeft;
    public GameObject buttonRight; 

    // Start is called before the first frame update
    void Start()
    {
        SelectWall();
    }


    public void DeactivateWall()
    {
        targetScript.isSelected = false; targetScript.sectionCam.SetActive(false);
    }



    void SelectWall()
    {
        //select the wall
        try { DeactivateWall(); }
        catch { }
        targetScript = targetWalls[targetNumber].GetComponent<wallMovement>();
        targetScript.isSelected = true;
        targetScript.sectionCam.SetActive(true);

        //change the terminal
        isX = targetScript.isX;
        ChangeButtons();
    }

    public void CycleTarget(bool cycleUp)
    {
        if (cycleUp && pauseGame.isGameRunning)
        {
            targetNumber++;
            if (targetNumber >= targetWalls.Count)
            {
                targetNumber = 0;
            }
        }
        else if (pauseGame.isGameRunning)
        {
            targetNumber--;
            if (targetNumber < 0)
            {
                targetNumber = targetWalls.Count - 1;
            }
        }

        SelectWall();
    }


    void ChangeButtons()
    {
        if (isX)
        {
            buttonUp.SetActive(false);
            buttonDown.SetActive(false);
            buttonLeft.SetActive(true);
            buttonRight.SetActive(true);
        }
        else
        {
            buttonUp.SetActive(true);
            buttonDown.SetActive(true);
            buttonLeft.SetActive(false);
            buttonRight.SetActive(false);
        }
    }


    public void CallWallMovement(bool isPositive)
    {
        if (isPositive && pauseGame.isGameRunning)
        {
            moveAmount = 1;
        }
        else if(pauseGame.isGameRunning)
        {
            moveAmount = -1;
        }
        targetScript.moveAmount = moveAmount;
        targetScript.MoveWalls();
    }


    void Update()
    {

    }


}
