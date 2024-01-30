using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class dialopenscript : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite dialopen;
     
    [YarnCommand("setdialopensprite")]
    public void Setdialopensprite(string expression)
    {
        switch (expression)
        {
            case "diallock_open":
                spriteRenderer.sprite = dialopen;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
