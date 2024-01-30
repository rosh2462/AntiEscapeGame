using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class remoteactivescript : MonoBehaviour
{
   public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    public Sprite remoteopen;
     
    [YarnCommand("setremoteopensprite")]
    public void Setremoteopensprite(string expression)
    {
        switch (expression)
        {
            case "remotescanner_open":
                spriteRenderer.sprite = remoteopen;
                break;
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }
}
