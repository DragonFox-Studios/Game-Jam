using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;
    private SpriteRenderer spr;

    public Sprite left;
    public Sprite right;
    public Sprite up;
    public Sprite down;
    public Sprite front;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponent<SpriteRenderer>();
    }







    void MovePlayer()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed * inputX, speed * inputY);

        movement = movement * Time.deltaTime;

        rb.velocity = (movement);

        if (inputX > 0)
        {
            Debug.Log("Right");
            spr.sprite = right;
        }
        else if (inputX < 0)
        {
            Debug.Log("left");
            spr.sprite = left;
        }
        else if (inputY > 0)
        {
            Debug.Log("up");
            spr.sprite = up;
        }
        else if (inputY < 0)
        {
            Debug.Log("down");
            spr.sprite = down;
        }
        else
        {
            Debug.Log("standing");
            spr.sprite = front;
        }

    }

    bool CheckFreeze()
    {
        if (terminalInteractor.terminalClosed && pauseGame.isGameRunning)
        {
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            return true;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            return false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (CheckFreeze()){
            MovePlayer();
        }
    }
}
