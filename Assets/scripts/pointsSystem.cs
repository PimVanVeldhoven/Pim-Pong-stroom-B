using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsSystem : MonoBehaviour
{
    /// <summary>
    /// the code that actually displays the score so the players can see there points
    /// it shows both sides there points
    /// </summary>
    public string leftOrRightWall;
    public int leftPoints;
    public int rightPoints;

    //makes the text field able to show a score that can be updated
    [SerializeField]
    Text scoreTextLeft;
    public Text scoreTextLeftPoints;
    // Start is called before the first frame update
    void Start()
    {
        //scoreTextLeftPoints = gameObject.canvas("scoreTextLeftPoints");
    }

    // Update is called once per frame
    void Update()
    {
        //the code that updates the score on the screen
        leftPoints = PlayerPrefs.GetInt("SCORE: ", 0);
        scoreTextLeftPoints.text = "SCORE: " + leftPoints.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //the code that updates the score after a point is scored so its actually counted for the wincondition etc
        if (collision.gameObject.CompareTag("leftVerticalWall"))
        {
            Debug.Log("bonked from behind");
            Debug.Log(leftPoints + " points left");
            leftPoints = PlayerPrefs.GetInt("SCORE: ", 0);

            leftPoints++;

            PlayerPrefs.SetInt("SCORE: ", leftPoints);
            PlayerPrefs.Save();

            Debug.Log("SCORE: " + leftPoints.ToString());
        }
        else if (collision.gameObject.CompareTag("rightVerticalWall"))
        {
            Debug.Log("bonked from behind");
            rightPoints = rightPoints + 1;
            Debug.Log(rightPoints + " points right");
        }
    }
}
