    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    private float rightBound = 20;
    private DisplayScore gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<DisplayScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound || transform.position.x > rightBound || transform.position.x < -rightBound)
        {
            Destroy(gameObject);
            gameManager.Lives -= 1;
            if(gameManager.Lives == 0)
            {
                Debug.Log("Game Over!!!");
            } 
            if(gameManager.Lives >= 0)
            {
                Debug.Log("Lives = " + gameManager.Lives);
            }
        }
    }
}
