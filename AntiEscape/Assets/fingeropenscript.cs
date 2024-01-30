using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class fingeropenscript : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite fingeropen;
     
    [YarnCommand("setfingeropensprite")]
    public void SetfingerSprite(string expression)
    {
        switch (expression)
        {
            case "fingerprint_open":
                spriteRenderer.sprite = fingeropen;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
