using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class vaseShattered : MonoBehaviour
{
    public SpriteRenderer spriteRenderervase; // Reference to the SpriteRenderer component

    public Sprite vase_triggered;
     
    [YarnCommand("setvasesprite")]
    public void SetvaseSprite(string expression)
    {
        switch (expression)
        {
            case "vase_triggered":
                spriteRenderervase.sprite = vase_triggered;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
