using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestroyer : MonoBehaviour
{
    public GameObject lostCanvas;
    public GameObject litCanvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))

        {
            Destroy(other.gameObject);
            


        }
        if (other.CompareTag("Bonfire"))
        {
            litCanvas.SetActive(false);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            CanvasOn();
            int endScore = other.GetComponent<PlayerMovement>().score;
            if (endScore>PlayerPrefs.GetInt("HS"))
            {
                PlayerPrefs.SetInt("HS", endScore);
            }
        }
    }
    
    void Update()
    {
        
    }
    public void CanvasOn()
    {
        lostCanvas.SetActive(true);
        GetComponent<AudioSource>().Play();
    }
}
