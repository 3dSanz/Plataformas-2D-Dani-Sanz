using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance {get; private set;}
    public bool _isGameOver = false;
    public GameObject _gameOver;
    public bool _isVictory = false;
    public GameObject _victory;
    //[SerializeField] float _victoryRate = 0.2f;
    public GameObject _star1;
    public GameObject _star2;
    public GameObject _star3;
    public GameObject _star4;
    public GameObject _star5;
    public GameObject _hp1;
    public GameObject _hp2;
    public GameObject _hp3;
    Player _player;
    SoundManager _sound;

    void Awake()
    {
        _player = GameObject.Find("Personaje").GetComponent<Player>();
        _sound = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        
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
        TakeDamage();
        if(_player._stars == 5)
        {
            Victory();
        }
    }

    public void GameOver()
    {
        if (_isVictory != true)
        {
            Debug.Log("Game Over");
            _isGameOver = true;
            SceneManager.LoadScene(2);
            _sound.StopBGM();
        }

    }

    public void Victory()
    {
        Debug.Log("Victory");
        _isVictory = true;
        //yield return new WaitForSeconds(_victoryRate);
        _sound.StopBGM();
        SceneManager.LoadScene(3);
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

    public void TakeDamage()
    {
        if(_player._hp==2)
        {
            _hp1.SetActive(false);
        }

        if(_player._hp==1)
        {
            _hp2.SetActive(false);
        }

        if(_player._hp==0)
        {
            GameOver();
        }

    }
}
