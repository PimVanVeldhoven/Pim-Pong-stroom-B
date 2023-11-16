using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class botPedal : MonoBehaviour
{
    /// <summary>
    /// the code for the pedal in 1 player mode so the pedal moves by its self it also has a max position so it dusnt
    /// go outside the borders of the game
    /// </summary>
    
    public float yPosition = 0f;
    public float ySpeed = 1f;
    public float maxPos = 3.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        //the movement of the pedal and it also checks if its past its max position
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, 0f);
        yPosition = transform.position.y;
        if (yPosition >= maxPos || yPosition <= -maxPos)
        {
            ySpeed = ySpeed * -1f;
        }
    }    
}
