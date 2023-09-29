
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xPosition = 2f;
    public float yPosition = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0f); 
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + 0.008f;
        yPosition = yPosition + 0.002f;
        transform.position = new Vector3(xPosition,yPosition, 0f);
    }
}
