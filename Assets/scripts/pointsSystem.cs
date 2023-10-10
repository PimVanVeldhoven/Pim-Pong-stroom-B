using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointsSystem : MonoBehaviour
{
    public string leftOrRightWall;
    public int leftPoints;
    public int rightPoints;

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
        leftPoints = PlayerPrefs.GetInt("SCORE: ", 0);
        scoreTextLeftPoints.text = "SCORE: " + leftPoints.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

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
