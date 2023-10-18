using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{
    public static bool isGrounded;
    private Animator _anim;

  /*  void Awake()
    {
        _anim = GameObject.Find("rogue").GetComponent<Animator>();
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           isGrounded = true;
           //_anim.SetBool("IsJumping", false);
        }
    
    }

        void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           isGrounded = true; 
          // _anim.SetBool("IsJumping", false);
        }
    }

        void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 3)
        {
           isGrounded = false; 
          // _anim.SetBool("IsJumping", true);
        }
    }
}
