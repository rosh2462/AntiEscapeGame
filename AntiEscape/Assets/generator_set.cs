using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class generator_set : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite generator_active;
     
    [YarnCommand("setgeneratorsprite")]
    public void SetglobeSprite(string expression)
    {
        switch (expression)
        {
            case "generator_triggered":
                spriteRenderer.sprite = generator_active;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
 