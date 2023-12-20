using System.Collections;
using UnityEngine;
using Yarn.Unity;

public class EnableDisableScript : MonoBehaviour
{
    // Reference to the YarnSpinner DialogueRunner
    public Yarn.Unity.DialogueRunner dialogueRunner;

    // GameObject to be enabled/disabled
    public GameObject targetGameObject1;

    public GameObject targetGameObject2;

     public GameObject targetGameObject3;

    public GameObject targetGameObject4;

    public GameObject targetGameObject5;
          


     public GameObject death;

     public GameObject death_ashok;

      public GameObject AshokdeathSprite;
 public GameObject AshokCorpse;


          public GameObject MathildadeathSprite;

           public GameObject toolsdisable;

           public GameObject knifeitem;

           public GameObject MathildaCorpse;

           public GameObject Lights;

          

    private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }

        // Subscribe to the Yarn command event
        dialogueRunner.AddCommandHandler("enableScene1", EnableScene1);
        dialogueRunner.AddCommandHandler("enableScene2", EnableScene2);
         dialogueRunner.AddCommandHandler("enableScene3", EnableScene3);
         dialogueRunner.AddCommandHandler("enableScene4", EnableScene4);
               dialogueRunner.AddCommandHandler("enableScene5", EnableScene5);
        dialogueRunner.AddCommandHandler("enabledeathMathilda", EnableDeathMat);
        dialogueRunner.AddCommandHandler("enabledeathAshok", EnableDeathAshok);
        dialogueRunner.AddCommandHandler("enableMathildaCorpse", EnableMathildaCorpse);
dialogueRunner.AddCommandHandler("enableAshokCorpse", EnableAshokCorpse);
        dialogueRunner.AddCommandHandler("enableLight", EnableLight);

        
        dialogueRunner.AddCommandHandler("disableScene1", DisableScene1);
        dialogueRunner.AddCommandHandler("disableScene2", DisableScene2);
        dialogueRunner.AddCommandHandler("disableScene3", DisableScene3);
        dialogueRunner.AddCommandHandler("disableScene4", DisableScene4);
         dialogueRunner.AddCommandHandler("disableScene5", DisableScene5);
        dialogueRunner.AddCommandHandler("disabledeathMathilda", DisableDeathMat);
        dialogueRunner.AddCommandHandler("disabledeathAshok", DisableDeathAshok);
        dialogueRunner.AddCommandHandler("disableMathilda", DisableMathildaSprite);
         dialogueRunner.AddCommandHandler("disableAshok", DisableAshokSprite);
        dialogueRunner.AddCommandHandler("disabletoolsitem", DisableTools1);
        
         dialogueRunner.AddCommandHandler("disableknife", DisableKnife);
         dialogueRunner.AddCommandHandler("disableLight", DisableLight);


    }

    // Yarn command to enable the target game object


private void EnableLight()
    {
        if (Lights != null)
        {
            Lights.SetActive(true);
        }
    }




    private void EnableScene1()
    {
        if (targetGameObject1 != null)
        {
            targetGameObject1.SetActive(true);
        }
    }

private void EnableScene2()
    {
        if (targetGameObject2 != null)
        {
            targetGameObject2.SetActive(true);
        }
    }

    private void EnableScene3()
    {
        if (targetGameObject3 != null)
        {
            targetGameObject3.SetActive(true);
        }
    }


 private void EnableDeathMat()
    {
        if (death != null)
        {
            death.SetActive(true);
        }
    }

 private void EnableDeathAshok()
    {
        if (death_ashok != null)
        {
            death_ashok.SetActive(true);
        }
    }
    

    private void EnableMathildaCorpse()
    {
        if (MathildaCorpse != null)
        {
            MathildaCorpse.SetActive(true);
        }
    }

private void EnableScene4()
    {
        if (targetGameObject4 != null)
        {
            targetGameObject4.SetActive(true);
        }
    }

      private void EnableScene5()
    {
        if (targetGameObject5 != null)
        {
            targetGameObject5.SetActive(true);
        }
    }

    private void EnableAshokCorpse()
    {
        if (AshokCorpse != null)
        {
            AshokCorpse.SetActive(true);
        }
    }




    // Yarn command to disable the target game object
    private void DisableScene1()
    {
        if (targetGameObject1 != null)
        {
            targetGameObject1.SetActive(false);
        }
    }

    private void DisableScene2()
    {
        if (targetGameObject2 != null)
        {
            targetGameObject2.SetActive(false);
        }
    }

    private void DisableScene3()
    {
        if (targetGameObject3 != null)
        {
            targetGameObject3.SetActive(false);
        }
    }


private void DisableScene4()
    {
        if (targetGameObject4 != null)
        {
            targetGameObject4.SetActive(false);
        }
    }
    

 private void DisableDeathMat()
    {
        if (death != null)
        {
            death.SetActive(false);
            
        }
    }

private void  DisableDeathAshok()
    {
        if (death_ashok != null)
        {
            death_ashok.SetActive(false);
            
        }
    }
   
private void DisableMathildaSprite()
    {
        if (MathildadeathSprite != null)
        {
            MathildadeathSprite.SetActive(false);
            
        }
    }

    private void DisableAshokSprite()
    {
        if (AshokdeathSprite != null)
        {
            AshokdeathSprite.SetActive(false);
            
        }
    }


private void DisableTools1()
    {
        if (toolsdisable != null)
        {
            toolsdisable.SetActive(false);
            
        }
    }
    
private void DisableKnife()
    {
        if (knifeitem != null)
        {
            knifeitem.SetActive(false);
            
        }
    }

private void DisableLight()
    {
        if (Lights != null)
        {
            Lights.SetActive(false);
            
        }
    }
private void DisableScene5()
    {
        if (targetGameObject5 != null)
        {
            targetGameObject5.SetActive(false);
            
        }
    }
    

             

}

