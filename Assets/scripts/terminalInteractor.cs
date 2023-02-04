using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminalInteractor : MonoBehaviour
{

    public GameObject terminalScreen;

    private bool interacting;
    public bool terminalClosed = true; //set this to True when terminal is closed

    public GameObject terminalCam;
    public float zoomTime;



    void Start()
    {
        
    }



    void OpenTerminal()
    {
        if (terminalClosed)
        {
            //Open Terminal
            terminalClosed = false;
            //add whatever visual trickery in here
            StartCoroutine(camZoomIn());

            Debug.Log("TESTTERMINALOPENED");
        }
        else
        {
            //Close Terminal
            terminalClosed = true;
            //add whatever visual trickery in here
            StartCoroutine(camZoomOut());

            Debug.Log("TESTTERMINALCLOSED");
        }

    }




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && interacting && terminalClosed)
        {
            OpenTerminal();
        }
        //test code
        if (Input.GetKeyDown(KeyCode.E))
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

    public IEnumerator camZoomIn()
    {
        terminalCam.SetActive(true);
        yield return new WaitForSeconds(zoomTime);
        terminalScreen.SetActive(true);
    }

    public IEnumerator camZoomOut()
    {
        terminalCam.SetActive(false);
        yield return new WaitForSeconds(zoomTime);
        terminalScreen.SetActive(false);
    }
}
