using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class PlayerSprite : MonoBehaviour
{

public Yarn.Unity.DialogueRunner dialogueRunner;
     public GameObject targetGameObject1;
public GameObject cabinet;
  public Animator animator;
      private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }

        // Subscribe to the Yarn command event
        dialogueRunner.AddCommandHandler("enableMathildaCharacter", EnableMathildaCharacter);
         dialogueRunner.AddCommandHandler("enableCabinet", EnableCabinet);
    }

    private void EnableMathildaCharacter()
    {
        if (targetGameObject1 != null)
        {
            targetGameObject1.SetActive(true);
        }
    }



    public void EnableCabinet()
    {

cabinet.GetComponent<cabinetInteractive>().enabled = true;
  animator.enabled=true;
    cabinet.GetComponent<CustomCursor>().enabled = true;


    }
    
//     public SpriteRenderer spriteRenderer;

//     public Sprite mathilda_2_2;
      
//     [YarnCommand("charactersprite")]
//     public void SetCharacterSprites(string expression)
//     {

// switch (expression)
//         {
//             case "mathilda_2_2":
//                 spriteRenderer.sprite = mathilda_2_2;
//                 spriteRenderer.enabled = true;
//                 break;
//             default:
//             Debug.LogWarning("Unknown expression: " + expression);
//             break;


//     }
// }



}
