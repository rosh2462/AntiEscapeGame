using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSoundManager : MonoBehaviour
{
      public AudioClip glass_shatter;

  public AudioClip stumble;

    public AudioClip scroll;
     public AudioClip Monster40;
public AudioClip Monster30;

public AudioClip Monster20;

public AudioClip Monster10;
public AudioClip Monster1;



private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


 public void Play(string soundName)
    {
        switch (soundName)
        {

            case "glass_shatter":
                audioSource.clip = glass_shatter;
                break;
            case "stumble":
                audioSource.clip = stumble;
                break;
              case "scroll":
                audioSource.clip = scroll;
                break;
                 case "monster30":
                audioSource.clip = Monster30;
                break;
                case "monster40":
                audioSource.clip = Monster40;
                break;
                case "monster20":
                audioSource.clip = Monster20;
                break;
                case "monster10":
                audioSource.clip = Monster10;
                break;
                case "monster1":
                audioSource.clip = Monster1;
                break;
                


        }
        audioSource.Play();

    }




}