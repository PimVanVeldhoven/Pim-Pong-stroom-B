using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class botPedal : MonoBehaviour
{
    
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
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, 0f);
        yPosition = transform.position.y;
        if (yPosition >= maxPos || yPosition <= -maxPos)
        {
            ySpeed = ySpeed * -1f;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (yPosition <= maxPos)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        //else if (yPosition >= -maxPos)
        //{
        //    ySpeed = ySpeed * -1f;
        //}
        //else
        //{
        //    yPosition = yPosition + ySpeed * Time.deltaTime;
        //    transform.position = new Vector3(transform.position.x, yPosition, 0f);
        //    yPosition = transform.position.y;
        //}

    }
    
}
