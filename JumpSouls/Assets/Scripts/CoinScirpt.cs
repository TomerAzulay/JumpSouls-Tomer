using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScirpt : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            
            Destroy(gameObject);
        }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
