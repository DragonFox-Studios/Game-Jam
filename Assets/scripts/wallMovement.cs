using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public Vector3 movement = new Vector3(100f, 0f);
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.None;

        rb.transform.position = movement;

        rb.constraints = RigidbodyConstraints2D.FreezeAll;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
