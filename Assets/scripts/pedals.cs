using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedals : MonoBehaviour
{
    /// <summary>
    /// the code for the player controlled paddles 
    /// it has a way to change wich peddal it is for instance the left one or the right so in the two player mode 
    /// you can actually play with two people using different pedals
    /// it also has a max value again so the pedals dont go out of bounds
    /// </summary>
    public float speed = 5f;
    public string leftOrRight;
    public float maxValue = 3.8f;
    //the code that makes the peddals move and checks wich side was detected
    void paddlecontrol(KeyCode up,KeyCode down )
    {
        if (Input.GetKey(up) && transform.position.y <= maxValue)
        {
            Debug.Log("W key");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -maxValue)
        {
            Debug.Log("S key");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the code that checks wich side of peddal it is
        if(leftOrRight == "left")
        {
            paddlecontrol(KeyCode.W, KeyCode.S);
        }else if(leftOrRight == "right")
        {
            paddlecontrol(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
