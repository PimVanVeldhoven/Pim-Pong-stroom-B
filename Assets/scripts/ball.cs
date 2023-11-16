
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ball : MonoBehaviour
{
    /// <summary>
    /// all the floats for speed and position of the ball
    /// 
    /// note this is the old code for only the ball collision is the new code thats used and actually functions in the game
    /// </summary>
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        //start position of ball
        transform.position = new Vector3(xPosition, yPosition, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        //the movement of the ball
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition,yPosition, 0f);
    }
}
