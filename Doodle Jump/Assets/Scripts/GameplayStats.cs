using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayStats : MonoBehaviour
{
    public Text scoreText;
    public PlayerMovement playerMovement;
    //
    public Text coinsText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerMovement.score.ToString();
        coinsText.text = playerMovement.CoinsCount.ToString();
    }
}
