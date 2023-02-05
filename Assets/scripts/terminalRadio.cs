using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class terminalRadio : MonoBehaviour
{

    private int targetNumber = 0;

    public int  moveAmount = 1;

    public bool isX = true;

    public Color targetColour;

    public List<GameObject> targetWalls = new List<GameObject>();

    private wallMovement targetScript;


    public static GameObject cycleDown;
    public static GameObject cycleUp;
    public static GameObject buttonUp;
    public static GameObject buttonDown;
    public static GameObject buttonLeft;
    public static GameObject buttonRight; 

    // Start is called before the first frame update
    void Start()
    {
    }


    public void DeactivateWall()
    {
        targetScript.isSelected = false; targetScript.sectionCam.SetActive(false);
    }



    public void SelectWall()
    {
        Debug.Log("selectWall");
        //select the wall
        try { DeactivateWall(); }
        catch { }
        targetScript = targetWalls[targetNumber].GetComponent<wallMovement>();
        targetScript.isSelected = true;
        targetScript.sectionCam.SetActive(true);
        GameObject targetWall = targetWalls[targetNumber].transform.GetChild(0).gameObject;
        Tilemap tilemap = targetWall.GetComponent<Tilemap>();
        tilemap.color = targetColour;
        //change the terminal
        isX = targetScript.isX;
        ChangeButtons();
    }

    public void DeselectWall()
    {
        GameObject targetWall = targetWalls[targetNumber].transform.GetChild(0).gameObject;
        Tilemap tilemap = targetWall.GetComponent<Tilemap>();
        tilemap.color = Color.white;
    }

    public void CycleTarget(bool cycleUp)
    {
        Debug.Log("cycleTarget");
        if (cycleUp && pauseGame.isGameRunning)
        {
            DeselectWall();
            targetNumber++;
            if (targetNumber >= targetWalls.Count)
            {
                targetNumber = 0;
            }
        }
        else if (pauseGame.isGameRunning)
        {
            DeselectWall();
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
        if (targetWalls.Count == 1)
        {
            cycleUp.SetActive(false);
            cycleDown.SetActive(false);
        }
        else
        {
            cycleUp.SetActive(true);
            cycleDown.SetActive(true);
        }
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
