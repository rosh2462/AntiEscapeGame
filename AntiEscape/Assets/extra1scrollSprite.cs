using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class extra1scrollSprite : MonoBehaviour
{
   public SpriteRenderer ScrollspriteRenderer; // Reference to the SpriteRenderer component

    public Sprite scrollclosed;
     
    [YarnCommand("rollup")]
    public void SettriggeredSprite(string expression)
    {
        switch (expression)
        {
            case "extra1scroll_triggered":
                ScrollspriteRenderer.sprite = scrollclosed;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
