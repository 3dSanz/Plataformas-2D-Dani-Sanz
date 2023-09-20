 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField]private float _playerSpeed = 5.5f;
    [SerializeField]private float _jumpForce = 5.5f;
    private float _playerInput;
    private float _jumpInput;
    private SpriteRenderer sP;
    private GroundSensor _gs;
    //private float _playerInputUpDown;  
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_gs = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        _gs = GetComponentInChildren<GroundSensor>();

    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();

    }

    private void FixedUpdate() {
        PlayerMovement();

    }

    void PlayerMovement(){
        _playerInput = Input.GetAxis("Horizontal");
        /*_playerInputUpDown = Input.GetAxis("Vertical");  
        transform.Translate(new Vector2(_playerInput,_playerInputUpDown) * _playerSpeed * Time.deltaTime);*/
         _rb.velocity = new Vector2 (_playerInput*_playerSpeed, _rb.velocity.y);
    }

    void PlayerJump(){
       if(Input.GetButtonDown("Jump") && _gs.isGrounded){
        _rb.AddForce(Vector2.up *_jumpForce, ForceMode2D.Impulse);
       }
        
    }

}
