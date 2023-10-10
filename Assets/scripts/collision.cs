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
    public int winCondition = 5;


    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-4f, 4f);
        xSpeed = xSpeed * -1.000001f;
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

        if(leftPoints >= winCondition) 
        {
            scoreText.text = "Left side wins";
            xSpeed = 0f;
            ySpeed = 0f;
        }
        else if(rightPoints >= winCondition) 
        {
            scoreText.text = "Right side wins";
            xSpeed = 0f;
            ySpeed = 0f;
        }
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
