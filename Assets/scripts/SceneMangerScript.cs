using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMangerScript : MonoBehaviour
{
    private Animator animator;
    public GameObject fadePanel;
    public GameObject btnPanel;
    public GameObject creditsPanel;
    public GameObject controlsPanel;

    [Header("Text Objects")]
    public GameObject textPanel;
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

    private void Start()
    {
        animator = fadePanel.GetComponent<Animator>();
    }

    public void StartIntro()
    {
        StartCoroutine(Intro());   
    }

    //Intro sequence
    public IEnumerator Intro()
    {
        fadePanel.SetActive(true);
        animator.SetBool("isFade", true);

        yield return new WaitForSeconds(wait1);

        btnPanel.SetActive(false);
        animator.SetBool("isFade", false);
        textPanel.SetActive(true);

        yield return new WaitForSeconds(wait2);

        line1.text = txt1;
        yield return new WaitForSeconds(wait3);
        line2.text = txt2;
        yield return new WaitForSeconds(wait3);
        line3.text = txt3;
        yield return new WaitForSeconds(wait3);
        line4.text = txt4;

        yield return new WaitForSeconds(wait1);

        animator.SetBool("isFade", true);

        yield return new WaitForSeconds(wait4);

        StartGame();
    }

    //Load game scene
    public void StartGame()
    {
        Debug.Log("Starting game");
        SceneManager.LoadScene("Game");
    }

    //Open and close credits window
    public void OpenCredits()
    {
        btnPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }
    public void CloseCredits()
    {
        btnPanel.SetActive(true);
        creditsPanel.SetActive(false);
    }

    //Open and close controls window
    public void OpenControls()
    {
        btnPanel.SetActive(false);
        controlsPanel.SetActive(true);
    }
    public void CloseControls()
    {
        btnPanel.SetActive(true);
        controlsPanel.SetActive(false);
    }


    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
