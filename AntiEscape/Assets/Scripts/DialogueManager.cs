using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Yarn.Unity;

public class DialogueManager : MonoBehaviour
{

    //public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRendererAnimal;

    //public Sprite door1crate;
     
    public Sprite trap1animal;

     

    [YarnCommand("objectsprite")]
    public void SetSprite(string expression)
    {

        switch (expression)
        {

            // case "door1crate_open":
            //     spriteRenderer.sprite = door1crate;
            //     break;

            case "trap1animal_triggered":
                spriteRendererAnimal.sprite = trap1animal;
                break;

             
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

}