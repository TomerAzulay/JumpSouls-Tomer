using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // 
    Rigidbody rb; 
    //
    public float movementPower = 15;
    public int score;
    public int CoinsCount;
    public int health = 3;
    public platformDestroyer platformDestroyer;



    public Transform playerLocation;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CoinScirpt>())
        {
            
            CoinsCount = CoinsCount + 10;
        }

        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CoinScirpt>())
        {

            GetComponent<AudioSource>().Play();
        }
    }
    void Update()
    {
        // 
        float horizontalMovement = Input.GetAxis("Horizontal")*movementPower;
        //
        Vector3 newMovement = rb.velocity; 
        //
        newMovement.x = horizontalMovement;
        //
        rb.velocity = newMovement;
        //check score is the highest score of the player. mathf is the transform float turning to int .
        ScoreSys();

        if (health <=0)
        {
            Destroy(gameObject);
            FindObjectOfType<platformDestroyer>().CanvasOn();
        }
        

       
        
    }
    public void ScoreSys()
    {
        int checkscore = Mathf.RoundToInt(transform.position.y * 2);

        if (checkscore > score)
        {
            score = checkscore;
        }

    }
}
