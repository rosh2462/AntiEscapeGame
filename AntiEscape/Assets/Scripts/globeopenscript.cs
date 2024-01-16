using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class globeopenscript : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite globeopen;
     
    [YarnCommand("setglobesprite")]
    public void SetglobeSprite(string expression)
    {
        switch (expression)
        {
            case "globe_open":
                spriteRenderer.sprite = globeopen;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
