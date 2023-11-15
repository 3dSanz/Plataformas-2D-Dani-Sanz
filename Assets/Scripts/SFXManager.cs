using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance {get; private set;}
    AudioSource _audio;
    public AudioClip playerJump;
    public AudioClip deathSound;
    public AudioClip pickupCoin;
    public AudioClip select;
    public AudioClip explosion;
    public AudioClip hitHurt;
    // Start is called before the first frame update

    void Awake()
    {
        _audio = GetComponent<AudioSource>();

        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        } else
        {
            instance = this;
        }
    }

    public void PlaySound(AudioClip clip)
    {
        _audio.PlayOneShot(clip);
    }

}
