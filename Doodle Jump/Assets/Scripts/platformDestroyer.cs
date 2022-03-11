using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformDestroyer : MonoBehaviour
{
    public GameObject lostCanvas;
   
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
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<PlayerMovement>())
        {
            CanvasOn();

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CanvasOn()
    {
        lostCanvas.SetActive(true);

    }
}
