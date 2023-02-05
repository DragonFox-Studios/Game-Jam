using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class finalTeminalScript : MonoBehaviour
{
    private bool interacting;
    public static bool terminalClosed = true;
    public ParticleSystem orb;
    public Gradient gradient;
    public Tilemap tilemap;

    private Animator animator;
    public Animator terminalAnim;
    public GameObject fadePanel;
    public GameObject txtPanel;

    [Header("Text Objects")]
    public Text line1;
    public Text line2;
    public Text line3;
    public Text line4;

    [Header("Text")]
    public string txt1;
    public string txt2;
    public string txt3;
    public string txt4;

    [Header("Waits")]
    public float wait1;
    public float wait2;
    public float wait3;
    public float wait4;
    public float wait5;
    public float wait6;

    private void Start()
    {
        animator = fadePanel.GetComponent<Animator>();
    }

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

        terminalAnim.SetBool("Hacking", true);

        yield return new WaitForSeconds(wait1);

        var main = orb.main;
        main.startColor = new ParticleSystem.MinMaxGradient(gradient);

        yield return new WaitForSeconds(wait2);

        tilemap.color = new Color(197, 0, 0, 0.745f);

        yield return new WaitForSeconds(wait3);

        fadePanel.SetActive(true);
        animator.SetBool("isFade", true);

        yield return new WaitForSeconds(wait4);

        txtPanel.SetActive(true);
        fadePanel.SetActive(false);

        yield return new WaitForSeconds(wait5);

        line1.text = txt1;
        yield return new WaitForSeconds(wait6);
        line2.text = txt2;
        yield return new WaitForSeconds(wait6);
        line3.text = txt3;
        yield return new WaitForSeconds(wait5);
        line4.text = txt4;

        yield return new WaitForSeconds(wait4);

        SceneManager.LoadScene("StartMenu");
    }
}
