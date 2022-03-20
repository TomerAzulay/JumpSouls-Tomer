using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bonFire : MonoBehaviour
{
    [Range(5, 20)]
    public float jumpForce;
    public GameObject lit;
    public GameObject sparkslit;
    public GameObject litOff;
    public GameObject litCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb.velocity.y < 0)
            {
                Vector3 newVelocity = rb.velocity;
                newVelocity.y = jumpForce;
                rb.velocity = newVelocity;
                lit.SetActive(true);
                sparkslit.SetActive(true);
                litOff.SetActive(false);
                FindObjectOfType<GameManager1>().BonfireCanvas();
            }
            if (other.CompareTag("Platform"))
            {
                Destroy(other.gameObject);
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
