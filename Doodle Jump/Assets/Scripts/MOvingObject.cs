using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvingObject : MonoBehaviour
{
    Rigidbody ribo;
     public bool isRight = true ;
    Vector3 velocityPlat = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        ribo = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRight)
        {
            velocityPlat = ribo.velocity;
            velocityPlat.x = 3f;
            ribo.velocity = velocityPlat;
            if (ribo.transform.position.x >=3.5f)
            {
                isRight = false;
            }
        }
        else
        {
            velocityPlat = ribo.velocity;
            velocityPlat.x = -3f;
            ribo.velocity = velocityPlat;
            if (ribo.transform.position.x <= -3.5f)
            {
                isRight = true;
            }
        }
    }
}
