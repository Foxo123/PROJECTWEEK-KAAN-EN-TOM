using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;



public class UiText : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public TMP_Text time;
    public TMP_Text gameOver;
    public int score = 0;
    public float timeLimit = 60;
    public bool timeUp = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame  
    void Update()
    {
        gameOver.text = "";
        if (timeLimit > -0.1)
        {
            timeLimit -= Time.deltaTime;
        }
        time.text = "Time: ";
        time.text += timeLimit.ToString();
        scoreDisplay.text = "Score: ";
        scoreDisplay.text += score.ToString();
        Debug.Log(score);
        if (timeLimit < 0)
        {
            timeUp = true;
        }
        if (timeUp)
        {
            gameOver.text = "Game Over";
        }
    }
 
}
