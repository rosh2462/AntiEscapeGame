using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRendererAnimal;

    public Sprite door1crate;
     
    public Sprite trap1animal;

     

    [YarnCommand("setsprite")]
    public void SetSprite(string expression)
    {

        switch (expression)
        {

            case "door1crate_open":
                spriteRenderer.sprite = door1crate;
                break;

            case "animal_active":
                spriteRendererAnimal.sprite = trap1animal;
                break;

             
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

}