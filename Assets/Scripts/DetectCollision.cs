using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    UiText text;
    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("scoredisplay").GetComponent<UiText>();//get the score from the scoredisplay object
    }

    // Update is called once per frame  
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //if the player enter the moles hitbox --> destroy mole
    {
        Destroy(gameObject);
        text.score++;
    }
}
