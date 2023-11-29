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
<<<<<<< Updated upstream
     
    public Sprite trap1animal;

     

=======
    public Sprite trap1animal;

>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
             
=======
            // case "extra1scroll_idle":
            //     spriteRenderer.sprite = extra1scroll;
            //     break;
>>>>>>> Stashed changes
            default:
                Debug.LogWarning("Unknown expression: " + expression);
                break;
        }
    }

}