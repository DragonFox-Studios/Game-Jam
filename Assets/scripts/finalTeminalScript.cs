using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalTeminalScript : MonoBehaviour
{
    private bool interacting;
    public static bool terminalClosed = true;
    public ParticleSystem orb;
    public Gradient gradient;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interacting && pauseGame.isGameRunning)
        {
            StartCoroutine(StartTerminal());
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

    public IEnumerator StartTerminal()
    {
        terminalClosed = false;
        yield return new WaitForSeconds(1);
        var main = orb.main;
        main.startColor = new ParticleSystem.MinMaxGradient(gradient);
    }
}
