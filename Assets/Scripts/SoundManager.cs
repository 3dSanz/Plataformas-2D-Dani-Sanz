using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {get; private set;}
    AudioSource _audio;
    public AudioClip playerJump;
    public AudioClip deathSound;
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

   /* public void JumpSound() 
    {
         _audio.PlayOneShot(playerJump);
    }

    public void DeathSound()
    {
        _audio.PlayOneShot(deathSound);
    }*/


}
