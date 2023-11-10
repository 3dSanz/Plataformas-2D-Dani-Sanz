using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    public int vidas;
    public bool _isGameOver = false;
    public GameObject _gameOver;
    public GameObject _star1;
    public GameObject _star2;
    public GameObject _star3;
    public GameObject _star4;
    public GameObject _star5;
    Player _player;

    void Awake()
    {
        _player = GameObject.Find("Personaje").GetComponent<Player>();
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            instance = this;
        }

    }

    void Update()
    {
        StarCount();
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        _isGameOver = true;
        _gameOver.SetActive(true);
    }

    void StarCount()
    {
        if(_player._stars==1)
        {
            _star1.SetActive(true);
        }

        if(_player._stars==2)
        {
            _star2.SetActive(true);
        }

        if(_player._stars==3)
        {
            _star3.SetActive(true);
        }

        if(_player._stars==4)
        {
            _star4.SetActive(true);
        }

        if(_player._stars==5)
        {
            _star5.SetActive(true);
        }
    }
}
