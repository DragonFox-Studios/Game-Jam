using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;
    public static bool terminalInteraction = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void MovePlayer()
    {
        if (terminalInteractor.terminalClosed)
        {
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(speed * inputX, speed * inputY);

            movement = movement * Time.deltaTime;

            rb.velocity = (movement);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!terminalInteraction)
        {
            MovePlayer();
        }
    }
}
