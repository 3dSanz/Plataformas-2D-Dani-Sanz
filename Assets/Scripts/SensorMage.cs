using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorMage : MonoBehaviour
{
    public static bool mageGrounded;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           mageGrounded = true;
        }
    
    }

        void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           mageGrounded = true; 
        }
    }

        void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           mageGrounded = false; 
        }
    }
}
