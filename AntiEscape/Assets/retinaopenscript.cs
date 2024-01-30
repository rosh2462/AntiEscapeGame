using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class retinaopenscript : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite retinaopen;
     
    [YarnCommand("setretinaopensprite")]
    public void SetretinaSprite(string expression)
    {
        switch (expression)
        {
            case "retinascanner_open":
                spriteRenderer.sprite = retinaopen;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
