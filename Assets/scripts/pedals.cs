using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedals : MonoBehaviour
{
    public float speed = 5f;
    public string leftOrRight;
    public float maxValue = 3.8f;
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
        if(leftOrRight == "left")
        {
            paddlecontrol(KeyCode.W, KeyCode.S);
        }else if(leftOrRight == "right")
        {
            paddlecontrol(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
