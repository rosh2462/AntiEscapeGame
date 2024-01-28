using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class PlayerSprite : MonoBehaviour
{

public Yarn.Unity.DialogueRunner dialogueRunner;
     public GameObject Mathilda_2;
     public GameObject Mathilda_3;
     public GameObject Mathilda_4;
     public GameObject Mathilda_5;

public GameObject Mathilda_1;

     public GameObject MarzannaCharacter;
public GameObject cabinet;
public GameObject globe;
public GameObject burner;

public GameObject altar;

public GameObject divination;

public GameObject gemstone;
public GameObject shelf;
public GameObject letters;


public GameObject Apparatus;
  public Animator animator;


 public GameObject Ashok1;
public GameObject Ashok2;
public GameObject Ashok3;
public GameObject Ashok4;
public GameObject Ashok5;

public GameObject Marzanna1;
public GameObject Marzanna2;
public GameObject Marzanna3;

public GameObject Marzanna4;
public GameObject Marzanna5;
 public GameObject Nanditha1;

 public GameObject Hugh1;
public GameObject Hugh5;

public GameObject cage;
public GameObject corpse;
public GameObject crate;

public GameObject tools;
public GameObject Animal;
public GameObject Chemicals;
  
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
 dialogueRunner.AddCommandHandler("enableglobe", EnableGlobe);
 dialogueRunner.AddCommandHandler("enablealtar", enableAltar);
dialogueRunner.AddCommandHandler("enableburner", enableBurner);
dialogueRunner.AddCommandHandler("enabledivination", enableDivination);
dialogueRunner.AddCommandHandler("enableshelf", enableShelf);
dialogueRunner.AddCommandHandler("enableMarzannaCharacter", EnableMarzannaCharacter);
dialogueRunner.AddCommandHandler("enableAshokCharacter", EnableAshokCharacter);
dialogueRunner.AddCommandHandler("enableHughCharacter", EnableHughCharacter);
dialogueRunner.AddCommandHandler("enablecage", Enablecage);

dialogueRunner.AddCommandHandler("enableletters", Enableletters);
dialogueRunner.AddCommandHandler("enablegemstone",enablegemStone);

dialogueRunner.AddCommandHandler("enableapparatus",enableApparatus);
dialogueRunner.AddCommandHandler("enableanimal",enableAnimal);

dialogueRunner.AddCommandHandler("enablecorpse",enableCorpse);
dialogueRunner.AddCommandHandler("enablecrate",enableCrate);
dialogueRunner.AddCommandHandler("enabletools",enableTools);
dialogueRunner.AddCommandHandler("enablechemicals",enableChemicals);
dialogueRunner.AddCommandHandler("enableNandithaCharacter", EnableNandithaCharacter);

    }



 private void EnableHughCharacter()
    {
        if (Hugh5 != null)
        {
            Hugh1.SetActive(true);
              Hugh5.SetActive(true);
             
        }
    }


private void EnableNandithaCharacter()
    {
        if (Nanditha1 != null)
        {
            Nanditha1.SetActive(true);
             
             
        }
    }
    





 private void enableApparatus()
    {
         Apparatus.GetComponent<apparatusInteractive>().enabled = true;
   
    Apparatus.GetComponent<CustomCursor>().enabled = true;
    }
   private void enableAnimal()
    {
        Animal.GetComponent<trap1AnimalInteractive>().enabled = true;   
    Animal.GetComponent<CustomCursor>().enabled = true;

    }

   private void enableCorpse(){
corpse.GetComponent<corpseInteractive>().enabled = true;   
 corpse.GetComponent<CustomCursor>().enabled = true;
}


 private void enableCrate(){
crate.GetComponent<door1crateinteractive>().enabled = true;   
 crate.GetComponent<CustomCursor>().enabled = true;
}

private void enableTools(){
tools.GetComponent<toolinteractivee>().enabled = true;   
tools.GetComponent<CustomCursor>().enabled = true;
}

public void enableChemicals(){
    Chemicals.GetComponent<chemicalinteractive>().enabled = true;   
Chemicals.GetComponent<CustomCursor>().enabled = true;
}







 private void EnableAshokCharacter()
    {
        if (Ashok2 != null)
        {
            Ashok1.SetActive(true);
            Ashok2.SetActive(true);
            Ashok3.SetActive(true);
            Ashok4.SetActive(true);
            Ashok5.SetActive(true);
        }
    }
  private void EnableMarzannaCharacter()
    {
         
             Marzanna1.SetActive(true);
             Marzanna2.SetActive(true);
             Marzanna3.SetActive(true);
            Marzanna4.SetActive(true);
            Marzanna5.SetActive(true);
      
    }

  private void enableShelf()
    {
      shelf.GetComponent<ShelfInteractive>().enabled = true;
   
    shelf.GetComponent<CustomCursor>().enabled = true;
    }
 private void Enablecage()
    {
      cage.GetComponent<GeneratorInteractive>().enabled = true;
   
    cage.GetComponent<CustomCursor>().enabled = true;
    }



    private void EnableMathildaCharacter()
    {
        if (Mathilda_2 != null)
        {
            Mathilda_1.SetActive(true);
            Mathilda_2.SetActive(true);
             Mathilda_3.SetActive(true);
              Mathilda_4.SetActive(true);
               Mathilda_5.SetActive(true);
        }
    }



    public void EnableCabinet()
    {

cabinet.GetComponent<cabinetInteractive>().enabled = true;
  animator.enabled=true;
    cabinet.GetComponent<CustomCursor>().enabled = true;


    }
public void EnableGlobe()
    {

globe.GetComponent<GlobeInteractive>().enabled = true;
   
    globe.GetComponent<CustomCursor>().enabled = true;


    }


    public void enableAltar()
    {

altar.GetComponent<AltarInteractive>().enabled = true;
   
    altar.GetComponent<CustomCursor>().enabled = true;


    }

     public void enableBurner()
    {

burner.GetComponent<BurnerInteractive>().enabled = true;
   
    burner.GetComponent<CustomCursor>().enabled = true;


    }


 public void enableDivination()
    {

divination.GetComponent<divinationInteractive>().enabled = true;
   
    divination.GetComponent<CustomCursor>().enabled = true;


    }


public void enablegemStone()
    {

gemstone.GetComponent<gemstonesInteractive>().enabled = true;
   
    gemstone.GetComponent<CustomCursor>().enabled = true;


    }


    
    
private void Enableletters()
    {
      letters.GetComponent<lettersInterative>().enabled = true;
   
    letters.GetComponent<CustomCursor>().enabled = true;
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
