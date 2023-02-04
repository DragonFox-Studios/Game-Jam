using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    public bool isX = true;
    public int moveAmount; //always send this value as either 1 or -1
    private Rigidbody2D rb;
    public bool isSelected = false;
    public int totalMovement;
    public int positiveMoveLimit = 5;
    public int negativeMoveLimit = -5;
    public GameObject sectionCam;
    
    
    void Start()
    {


    }

    void WallShift()
    {
        if (isX)
        {
            rb.transform.position = rb.transform.position + new Vector3(moveAmount, 0f);
        }
        else
        {
            rb.transform.position = rb.transform.position + new Vector3(0f, moveAmount);
        }
    }

    public void MoveWalls()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.constraints = RigidbodyConstraints2D.None;

        if ((moveAmount > 0 && totalMovement < positiveMoveLimit) || (moveAmount < 0 && totalMovement > negativeMoveLimit))
        {
            WallShift();
            totalMovement = totalMovement + moveAmount;
        }
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }



    void Update()
    {

    }
}
