using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Soundscript : MonoBehaviour
{
      private AudioSource audioSource;
     public AudioClip clickSound;

public Yarn.Unity.DialogueRunner runner;
      void Start()
    {
         
  runner.AddCommandHandler("playSound", PlaySound);
         
         audioSource = GetComponent<AudioSource>();
          if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
         
         
          
    }

 

       void PlaySound()
    {

        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
            Debug.Log("Sound Plays");
        }
    }
}
