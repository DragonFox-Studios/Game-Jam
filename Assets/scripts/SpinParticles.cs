using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinParticles : MonoBehaviour
{
    public float speed;


    void Update()
    {   
        transform.Rotate(speed * Time.deltaTime, 1, 1);
        //transform.rotation = Quaternion.Euler(0, 90, -90);
        
    }
}
