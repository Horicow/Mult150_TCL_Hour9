using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour_9_TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            print(gameObject.name + " was hit by " + other.gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
