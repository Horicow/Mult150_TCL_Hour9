using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // ball will start at 0 count
    int bounceCount = 0; 

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ball")) // Calling the ball 
            {
                bounceCount++; // Increment bounce count
                Debug.Log("Bounce Count: " + bounceCount); // Counting the ball bounces
            }
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
