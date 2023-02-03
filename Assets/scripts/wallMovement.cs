using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    public bool isX = true;
    public float moveAmount; //always send this value as either 1 or -1
    private Rigidbody2D rb;
    public bool isSelected = false;
   
    
    
    // Start is called before the first frame update
    void Start()
    {


    }


    public void MoveWalls()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;

        if (isX)
        {
            rb.transform.position = rb.transform.position + new Vector3(moveAmount, 0f);
        }
        else
        {
            rb.transform.position = rb.transform.position + new Vector3(0f, moveAmount);
        }
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }



    // Update is called once per frame
    void Update()
    {

    }
}
