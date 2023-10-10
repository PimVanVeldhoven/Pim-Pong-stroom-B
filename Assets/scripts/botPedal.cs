using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botPedal : MonoBehaviour
{
    
    public float yPosition = 0;
    public float ySpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        yPosition = yPosition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, yPosition, 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("horizontalwalls"))
        {
            ySpeed = ySpeed * -1f;
        }
    }
    
}
