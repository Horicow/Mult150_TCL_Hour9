using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour_9_MotionScprit : MonoBehaviour
{

    float moveSpeed = 3f; // how fast the sphere will move


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // arrow key input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // creating movement vectors
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        // Moving the sphere
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
