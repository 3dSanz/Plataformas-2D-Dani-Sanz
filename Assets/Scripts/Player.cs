using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    [Header("Player Stats")]
    [Tooltip("Controla la velocidad del personaje")]
    [SerializeField]private float _playerSpeed = 5.5f;
    [Tooltip("Controla la fuerza de salto del personaje")]
    [SerializeField]private float _jumpForce = 5.5f;
    private float _playerInput;
    private float _jumpInput;
    //private GroundSensor _gs;
    [SerializeField]private Animator _anim;
    [SerializeField]private PlayableDirector _director;

    //private float _playerInputUpDown;  
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_gs = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();
        //_gs = GetComponentInChildren<GroundSensor>();
       // _anim = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && GroundSensor.isGrounded)
        {
            PlayerJump();
        }
        _anim.SetBool("IsJumping", !GroundSensor.isGrounded);

        if (Input.GetButtonDown("Fire2"))
        {
            _director.Play();
        }
    }

    private void FixedUpdate() 
    {
        PlayerMovement();

    }

    void PlayerMovement()
    {
        _playerInput = Input.GetAxis("Horizontal");
        /*_playerInputUpDown = Input.GetAxis("Vertical");  
        transform.Translate(new Vector2(_playerInput,_playerInputUpDown) * _playerSpeed * Time.deltaTime);*/
         _rb.velocity = new Vector2 (_playerInput*_playerSpeed, _rb.velocity.y);

          if(_playerInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            _anim.SetBool("IsRunning", true);
        }
        else if(_playerInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            _anim.SetBool("IsRunning", true);
        }
        else
        {
            _anim.SetBool("IsRunning", false);
        }
    }

    void PlayerJump()
    {
        _rb.AddForce(Vector2.up *_jumpForce, ForceMode2D.Impulse);

    }

    public void SignalTest()
    {
        Debug.Log("Señal recibida");
    }
    
}
