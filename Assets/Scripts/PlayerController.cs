using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10f;
    public float zRangeDown = -11.5f;
    public float zRangeUp = 2f;
    UiText time;

    // Start is called before the first frame update
    void Start()
    {
        time = GameObject.Find("scoredisplay").GetComponent<UiText>();
    }

    // Update is called once per frame
    void Update()
    {
        //input from the player
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        


        //prevent the player from going out of bounds
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zRangeUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUp);
        }
        else if (transform.position.z < zRangeDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeDown);
        }

        //translate the input to movement in the game
        if (!time.timeUp)//if the time is up stop movement
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
            transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);
        }

            



    }
}
