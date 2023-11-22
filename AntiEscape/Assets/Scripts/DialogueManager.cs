using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{  
    
     public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite door1crate;
  //  public Sprite extra1scroll;
  

    [YarnCommand("setsprite")]
    public void SetSprite(string expression)
    {
        switch (expression)
        {
            case "door1crate_open":
                spriteRenderer.sprite = door1crate;
                break;
            // case "extra1scroll_idle":
            //     spriteRenderer.sprite = extra1scroll;
            //     break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

}
