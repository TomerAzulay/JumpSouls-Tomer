using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    
    public PlayerMovement playerMovement;

    private void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponent<PlayerMovement>())
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            FindObjectOfType<platformDestroyer>().CanvasOn();
        }

    }
    

}
