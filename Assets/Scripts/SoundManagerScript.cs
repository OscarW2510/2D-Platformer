using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip deadSound, coinSound, levelcompleteSound;
    static AudioSource audioSrc;    

    void Start()
    {

        levelcompleteSound = Resources.Load<AudioClip>("LevelComplete");
        deadSound = Resources.Load<AudioClip>("Death");
        coinSound = Resources.Load<AudioClip>("Coins");
        audioSrc = GetComponent<AudioSource>();
    }


    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Death":
                audioSrc.PlayOneShot(deadSound);
                break;
            case "Coins":
                audioSrc.PlayOneShot(coinSound);
                break;
            case "LevelComplete":
                audioSrc.PlayOneShot(levelcompleteSound);
                break;

        }
    }



}
