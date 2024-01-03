using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    public float Lives = 3;
    public float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives = " + Lives);
        Debug.Log("Score = " + Score);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
