using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalRadio : MonoBehaviour
{

    public bool move = false;

    public bool cycleTarget = false;

    private int targetNumber = 0;

    public int  moveAmount = 1;

    public bool isX = true;

    public List<GameObject> targetWalls = new List<GameObject>();

    private wallMovement targetScript;



    // Start is called before the first frame update
    void Start()
    {
        SelectWall();
    }




    void SelectWall()
    {
        //select the wall
        try { targetScript.isSelected = false; }
        catch { }
        targetScript = targetWalls[targetNumber].GetComponent<wallMovement>();
        targetScript.isSelected = true;

        //change the terminal
        isX = targetScript.isX;
    }

    void CycleTarget()
    {
        targetNumber++;
        if (targetNumber >= targetWalls.Count)
        {
            targetNumber = 0;
        }
        SelectWall();
    }


    void CallWallMovement()
    {
        targetScript.moveAmount = moveAmount;
        targetScript.MoveWalls();
    }


    void Update()
    {
        if (cycleTarget)
        {
            CycleTarget();
            cycleTarget = false;
        }

        if (move)
        {
            CallWallMovement();
            move = false;
        }




    }


}
