using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;



public class UiText : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public TMP_Text time;
    public int score = 0;
    public float timeLimit = 60;


    // Start is called before the first frame update
    void Start()
    {
        
    }
        
    // Update is called once per frame  
    void Update()
    {
        timeLimit -= Time.deltaTime;
        time.text = "Time: ";
        time.text += timeLimit.ToString();
        scoreDisplay.text = "Score: ";
        scoreDisplay.text += score.ToString();
        Debug.Log(score);
    }
 
}
