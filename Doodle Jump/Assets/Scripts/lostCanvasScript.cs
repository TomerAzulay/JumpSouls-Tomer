using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lostCanvasScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("doodleJump");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
