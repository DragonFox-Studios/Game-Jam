using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameObjectLocator : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void findTerminalCycle(bool isPositive)
    {
        Debug.Log("terminalcycle");

        terminalRadio currentRadioScript = terminalInteractor.currentTerminal.GetComponent<terminalRadio>();


        currentRadioScript.CycleTarget(isPositive);

        


    }

    public void findTerminalMove(bool isPositive)
    {
        Debug.Log("terminalmove");

        terminalRadio currentRadioScript = terminalInteractor.currentTerminal.GetComponent<terminalRadio>();

        currentRadioScript.CallWallMovement(isPositive);


    }


    // Update is called once per frame
    void Update()
    {





        



    }
}
