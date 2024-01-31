using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

   public AudioClip mood10;
      public AudioClip mood40;
public AudioSource audioSource1;
    public AudioSource audioSource2;
                public AudioSource  audioSource3;

              public AudioSource  audioSource4;
public AudioClip mood30;

public AudioClip mood20;
    // Add more AudioClip fields as needed
    

    

    public void Play(string soundName)
    {
        switch (soundName)
        {
            
                case "mood30":
                audioSource1.clip = mood30;
                 audioSource1.Play();
                break;
                case "mood40":
                audioSource2.clip = mood40;
                audioSource2.Play();
                break;
                case "mood20":
                audioSource3.clip = mood20;
                audioSource3.Play();
                break;
                case "mood10":
                audioSource4.clip = mood10;
                 audioSource4.Play();
                break;
                
               
            // Add more cases as needed
            default:
                Debug.LogWarning("Sound " + soundName + " not found!");
                return;
        }
       
        
         
         
    }
}