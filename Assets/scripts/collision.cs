using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class collision : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;
    public float leftPoints;
    public float rightPoints;
    public TMP_Text scoreText;
    public int leftScore = 0;
    public int rightScore = 0;


    void resetBall()
    {
        xPosition = 0f;
        yPosition = 0f;
        xSpeed = xSpeed * -1.0001f;
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + xSpeed * Time.deltaTime;
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Boink!");
        if (collision.gameObject.CompareTag("horizontalWall")) 
        {
            Debug.Log("bonked from above or below");
            ySpeed = ySpeed * -1f;
        }else if (collision.gameObject.CompareTag("verticalWall")) 
        {
            Debug.Log("bonked from behind");
            xSpeed = xSpeed * -1.1f;
        }else if (collision.gameObject.CompareTag("leftVerticalWall")) 
        {
            Debug.Log("point scored on left");
           resetBall();
            rightPoints++;
            scoreText.text = leftPoints + " - " + rightPoints;
        }
        else if (collision.gameObject.CompareTag("rightVerticalWall"))
        {
            Debug.Log("point scored on right");
            resetBall();
            leftPoints++;
            scoreText.text = leftPoints + " - " + rightPoints;
        }
    }
}
