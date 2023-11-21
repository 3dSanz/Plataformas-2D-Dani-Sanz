using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickup : MonoBehaviour
{
    BoxCollider2D _bc;

    void Awake()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && other.gameObject.layer == 9)
        {
            Destroy(this.gameObject);
        }
    }
}
