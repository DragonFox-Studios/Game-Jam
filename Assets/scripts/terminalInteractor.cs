using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalInteractor : MonoBehaviour
{
    private bool interacting;
    public bool terminalClosed = true; //set this to True when terminal is closed

    // Start is called before the first frame update
    void Start()
    {
        
    }



    void OpenTerminal()
    {
        terminalClosed = false;
        //add whatever visual trickery in here
        Debug.Log("TESTTERMINALOPENED");
    }




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && interacting && terminalClosed)
        {
            OpenTerminal();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interacting = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interacting = false;
    }
}
