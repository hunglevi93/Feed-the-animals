using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private DisplayScore gameManager;
    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<DisplayScore>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (!gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            gameManager.Score += 1;
            Debug.Log("Score = " + gameManager.Score);
        }
        else
        {
            Destroy(other.gameObject);
            gameManager.Lives -= 1;
            if (gameManager.Lives == 0)
            {

                Debug.Log("Game Over!!!");
            }
            if (gameManager.Lives >= 0)
            {
                Debug.Log("Lives = " + gameManager.Lives);
            }
        }
    }
}
