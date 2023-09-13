using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Rigidbody2D rb;
    [SerializeField]private float _playerSpeed = 5.5f;
    private float _playerInput;
    private float _playerInputUpDown;  
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    private void FixedUpdate() {
        //rb.velocity = new Vector2 (_playerInput*_playerSpeed, rb.velocity.y);
        
    }

    void PlayerMovement(){
        _playerInput = Input.GetAxis("Horizontal");
        _playerInputUpDown = Input.GetAxis("Vertical");  
        transform.Translate(new Vector2(_playerInput,_playerInputUpDown) * _playerSpeed * Time.deltaTime);
    }

}
