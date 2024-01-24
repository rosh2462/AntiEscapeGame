using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class burnertrigger : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite burnertriggered;
     
    [YarnCommand("setburnersprite")]
    public void SetglobeSprite(string expression)
    {
        switch (expression)
        {
            case "burner_triggered":
                spriteRenderer.sprite = burnertriggered;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
