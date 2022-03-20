using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlatformScript : MonoBehaviour
{
    Rigidbody rb;
    bool right = true ;
    Vector3 speed = new Vector3 (); 
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            speed = rb.velocity;
            speed.x = 3f;
            rb.velocity = speed;
            if (rb.transform.position.x>=3.5f)
            {
                right = false;
            }
        }
        else
        {
            speed = rb.velocity;
            speed.x = -3f;
            rb.velocity = speed;
            if (rb.transform.position.x<=-3.5f)
            {
                right = true;
            }
        }
    }
}
