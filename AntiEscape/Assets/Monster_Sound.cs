using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class Monster_Sound : MonoBehaviour
{

public MonsterSoundManager soundManager;

  
    private void Awake()
    {
         
        soundManager = FindObjectOfType<MonsterSoundManager>();
    }

    [YarnCommand("playrestsound")]
    public void PlaySound(string soundName)
    {
         
        switch (soundName)
        {
                case "glass_shatter":
                soundManager.Play("glass_shatter");
                break;
                case "stumble":
                soundManager.Play("stumble");
                break;
                case "scroll":
                soundManager.Play("scroll");
                break;
                case "monster40":
                soundManager.Play("monster40");
                break;
                case "monster30":
                soundManager.Play("monster30");
                break;
                case "monster20":
                soundManager.Play("monster20");
                break;
                case "monster10":
                soundManager.Play("monster10");
                break;
                case "monster1":
                soundManager.Play("monster1");
                break;
                case "ashok":
                soundManager.Play("ashok");
                break;
                case "nanditha":
                soundManager.Play("nanditha");
                break;
                case "hugh":
                soundManager.Play("hugh");
                break;
                case "mathilda":
                soundManager.Play("mathilda");
                break;
                case "marzanna":
                soundManager.Play("marzanna");
                break;
                case "death_ashok":
                soundManager.Play("death_ashok");
                break;
                case "death_nanditha":
                soundManager.Play("death_nanditha");
                break;
                case "death_marzanna":
                soundManager.Play("death_marzanna");
                break;
                case "death_mathilda":
                soundManager.Play("death_mathilda");
                break;
                case "death_hugh":
                soundManager.Play("death_hugh");
                break;
            default:
                Debug.LogWarning("Sound " + soundName + " not found!");
                break;
        }
    }
}
