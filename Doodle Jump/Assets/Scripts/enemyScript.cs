using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public GameObject lostCanvas;
    public platformDestroyer platformDestroyer;

    private void Start()
    {
          
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            Destroy(other.gameObject);
            FindObjectOfType<platformDestroyer>().CanvasOn();
            
        }

    }
    

}
