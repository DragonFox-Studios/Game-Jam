using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMangerScript : MonoBehaviour
{
    private Animator animator;
    public GameObject fadePannel;
    public GameObject btnPannel;

    [Header("Text Objects")]
    public GameObject textPannel;
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
        animator = fadePannel.GetComponent<Animator>();
    }

    public void StartIntro()
    {
        StartCoroutine(Intro());   
    }

    public IEnumerator Intro()
    {
        fadePannel.SetActive(true);
        animator.SetBool("isFade", true);

        yield return new WaitForSeconds(wait1);

        btnPannel.SetActive(false);
        animator.SetBool("isFade", false);
        textPannel.SetActive(true);

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

    public void StartGame()
    {
        Debug.Log("Starting game");
        SceneManager.LoadScene("Game");
    }

    public void OpenOptions()
    {

    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
