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
public GameObject plants;
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
 public GameObject Nanditha2;
 public GameObject Nanditha3;
 public GameObject Nanditha4;
 public GameObject Nanditha5;

 public GameObject Hugh1;
  public GameObject Hugh2;

   public GameObject Hugh3;
    public GameObject Hugh4;

public GameObject Hugh5;

public GameObject cage;
public GameObject corpse;
public GameObject crate;

public GameObject window;
public GameObject bookshelf;
public GameObject tools;
public GameObject Animal;
public GameObject Chemicals;
public GameObject patch;
public GameObject telescope;
public GameObject orrery;
public GameObject Can;
public GameObject Generator;
public GameObject Vase;
  public GameObject effigie;
      private void Start()
    {
        // Ensure the dialogueRunner is assigned
        if (dialogueRunner == null)
        {
            Debug.LogError("DialogueRunner not assigned in YarnCommandExample script!");
        }
        dialogueRunner.AddCommandHandler("enableMarzannaCharacter", EnableMarzannaCharacter);
dialogueRunner.AddCommandHandler("enableAshokCharacter", EnableAshokCharacter);
dialogueRunner.AddCommandHandler("disableAshokCharacter", DisableAshokCharacter);
dialogueRunner.AddCommandHandler("disableMarzannaCharacter", DisableMarzannaCharacter);

        // Subscribe to the Yarn command event
        dialogueRunner.AddCommandHandler("enableMathildaCharacter", EnableMathildaCharacter);
        dialogueRunner.AddCommandHandler("disableMathildaCharacter", DisableMathildaCharacter);
         dialogueRunner.AddCommandHandler("enableCabinet", EnableCabinet);
             dialogueRunner.AddCommandHandler("disablecabinet", Disablecabinet);
 dialogueRunner.AddCommandHandler("enableglobe", EnableGlobe);
 dialogueRunner.AddCommandHandler("disableglobe", Disableglobe);
 dialogueRunner.AddCommandHandler("enablealtar", enableAltar);
  dialogueRunner.AddCommandHandler("disablealtar",DisableAltar);
dialogueRunner.AddCommandHandler("enableburner", enableBurner);
dialogueRunner.AddCommandHandler("disableburner", disableBurner);
dialogueRunner.AddCommandHandler("enabledivination", enableDivination);
dialogueRunner.AddCommandHandler("disabledivination", Disabledivination);

dialogueRunner.AddCommandHandler("enablecan", enableCan);
dialogueRunner.AddCommandHandler("disablecan",disableCan);

dialogueRunner.AddCommandHandler("enableorrey", Enableorrey);
dialogueRunner.AddCommandHandler("disableorrey",Disableorrey);


dialogueRunner.AddCommandHandler("enableeffigie", Enableeffigie);
dialogueRunner.AddCommandHandler("disableeffigie",Disableeffigie);


dialogueRunner.AddCommandHandler("enablepatch", enablePatch);
dialogueRunner.AddCommandHandler("disablepatch",disablePatch);


dialogueRunner.AddCommandHandler("enabletelescope", enableTelescope);
dialogueRunner.AddCommandHandler("disabletelescope",disableTelescope);


dialogueRunner.AddCommandHandler("enablevase", Enablevase);
dialogueRunner.AddCommandHandler("disablevase",Disablevase);


dialogueRunner.AddCommandHandler("enablegenerator", Enablegenerator);
dialogueRunner.AddCommandHandler("disablgenerator",Disablegenerator);




dialogueRunner.AddCommandHandler("enableshelf", enableShelf);
dialogueRunner.AddCommandHandler("disableshelf", DisableShelf);
dialogueRunner.AddCommandHandler("enableplants", Enableplants);
dialogueRunner.AddCommandHandler("disableplants", Disableplants);
dialogueRunner.AddCommandHandler("enablebookshelf", Enablebookshelf);
dialogueRunner.AddCommandHandler("disablebookshelf", Disablebookshelf);

dialogueRunner.AddCommandHandler("enableHughCharacter", EnableHughCharacter);
dialogueRunner.AddCommandHandler("disableHughCharacter", DisableHughCharacter);
dialogueRunner.AddCommandHandler("enablecage", Enablecage);
dialogueRunner.AddCommandHandler("disablecage", Disablecage);

dialogueRunner.AddCommandHandler("enableletters", Enableletters);
dialogueRunner.AddCommandHandler("enablegemstone",enablegemStone);
dialogueRunner.AddCommandHandler("disablegemStone",DisablegemStone);


dialogueRunner.AddCommandHandler("enableapparatus",enableApparatus);
dialogueRunner.AddCommandHandler("disableapparatus",disableApparatus);
dialogueRunner.AddCommandHandler("enableanimal",enableAnimal);
dialogueRunner.AddCommandHandler("disableanimal",disableAnimal);

dialogueRunner.AddCommandHandler("enablecorpse",enableCorpse);
dialogueRunner.AddCommandHandler("enablecrate",enableCrate);
dialogueRunner.AddCommandHandler("disablecrate",Disablecrate);

dialogueRunner.AddCommandHandler("enabletools",enableTools);
dialogueRunner.AddCommandHandler("disabletools",Disabletools);
dialogueRunner.AddCommandHandler("enablechemicals",enableChemicals);
dialogueRunner.AddCommandHandler("disablechemicals",disableChemicals);

dialogueRunner.AddCommandHandler("enableNandithaCharacter", EnableNandithaCharacter);
dialogueRunner.AddCommandHandler("disableNandithaCharacter", DisableNandithaCharacter);
dialogueRunner.AddCommandHandler("disablewindow", DisableWindow);
dialogueRunner.AddCommandHandler("enablewindow", EnableWindow);
dialogueRunner.AddCommandHandler("disableletters", Disableletters);

dialogueRunner.AddCommandHandler("disablecorpse",disableCorpse);
    }



 private void EnableHughCharacter()
    {
        if (Hugh5 != null)
        {
            Hugh1.SetActive(true);
             Hugh2.SetActive(true);
             Hugh3.SetActive(true);
             Hugh4.SetActive(true);
              Hugh5.SetActive(true);
             
        }
    }

private void DisableHughCharacter()
    {
        if (Hugh5 != null)
        {
            Hugh1.SetActive(false);
            Hugh2.SetActive(false);
            Hugh3.SetActive(false);
            Hugh4.SetActive(false);
              Hugh5.SetActive(false);
             
        }
    }




private void EnableNandithaCharacter()
    {
        if (Nanditha1 != null)
        {
            Nanditha1.SetActive(true);
            Nanditha2.SetActive(true);
            Nanditha3.SetActive(true); 
            Nanditha4.SetActive(true);
            Nanditha5.SetActive(true); 
        }
    }
    

 private void DisableNandithaCharacter(){
     if (Nanditha1 != null)
        {
            Nanditha1.SetActive(false);
            Nanditha2.SetActive(false);
            Nanditha3.SetActive(false); 
            Nanditha4.SetActive(false);
            Nanditha5.SetActive(false); 
        }
 }





 private void enableApparatus()
    {
         Apparatus.GetComponent<apparatusInteractive>().enabled = true;
   
    Apparatus.GetComponent<CustomCursor>().enabled = true;
    }


 private void disableApparatus(){
 Apparatus.GetComponent<apparatusInteractive>().enabled = false;
    Apparatus.GetComponent<PolygonCollider2D>().enabled=false;
    Apparatus.GetComponent<CustomCursor>().enabled = false;

}




private void Enablebookshelf()
    {
        bookshelf.GetComponent<bookcaseinteractive>().enabled = true;   
    bookshelf.GetComponent<CustomCursor>().enabled = true;
    

    }



private void Disablebookshelf(){

bookshelf.GetComponent<bookcaseinteractive>().enabled = false;   
    bookshelf.GetComponent<CustomCursor>().enabled = false;
     bookshelf.GetComponent<BoxCollider2D>().enabled=false;

}
















 private void Enableplants()
    {
        plants.GetComponent<plantInteractive>().enabled = true;   
    plants.GetComponent<CustomCursor>().enabled = true;
    

    }


 private void Disableplants()
 {
        plants.GetComponent<plantInteractive>().enabled = false;   
    plants.GetComponent<CustomCursor>().enabled = false;
      plants.GetComponent<PolygonCollider2D>().enabled=false;

    }


   private void enableAnimal()
    {
        Animal.GetComponent<trap1AnimalInteractive>().enabled = true;   
    Animal.GetComponent<CustomCursor>().enabled = true;

    }


    


    private void disableAnimal(){
Animal.GetComponent<trap1AnimalInteractive>().enabled = false;   
 Animal.GetComponent<BoxCollider2D>().enabled=false;
 Animal.GetComponent<CustomCursor>().enabled = false;

}

   private void enableCorpse(){
corpse.GetComponent<corpseInteractive>().enabled = true;   
 corpse.GetComponent<CustomCursor>().enabled = true;
}


 private void enableCrate(){
crate.GetComponent<door1crateinteractive>().enabled = true;   
 crate.GetComponent<CustomCursor>().enabled = true;
}

 private void Disablecrate(){
crate.GetComponent<door1crateinteractive>().enabled = false;   
crate.GetComponent<PolygonCollider2D>().enabled=false;
 crate.GetComponent<CustomCursor>().enabled = false;

}



private void enableTools(){
tools.GetComponent<toolinteractivee>().enabled = true;   
tools.GetComponent<CustomCursor>().enabled = true;
}

private void  Disabletools(){
tools.GetComponent<toolinteractivee>().enabled = false;
tools.GetComponent<PolygonCollider2D>().enabled=false;   
tools.GetComponent<CustomCursor>().enabled = false;

}



public void enableChemicals(){
    Chemicals.GetComponent<chemicalinteractive>().enabled = true;   
Chemicals.GetComponent<CustomCursor>().enabled = true;
}


public void disableChemicals(){
 Chemicals.GetComponent<chemicalinteractive>().enabled = false;
   Chemicals.GetComponent<BoxCollider2D>().enabled=false;
    Chemicals.GetComponent<CustomCursor>().enabled = false;
}



public void Disableletters(){
  letters.GetComponent<lettersInterative>().enabled = false;
   letters.GetComponent<PolygonCollider2D>().enabled=false;
    letters.GetComponent<CustomCursor>().enabled = false;
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


    private void DisableAshokCharacter()
    {
        if (Ashok2 != null)
        {
            Ashok1.SetActive(false);
            Ashok2.SetActive(false);
            Ashok3.SetActive(false);
            Ashok4.SetActive(false);
            Ashok5.SetActive(false);
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


    private void DisableMarzannaCharacter(){
        Marzanna1.SetActive(false);
             Marzanna2.SetActive(false);
             Marzanna3.SetActive(false);
            Marzanna4.SetActive(false);
            Marzanna5.SetActive(false);
    }

    

  private void enableShelf()
    {
      shelf.GetComponent<ShelfInteractive>().enabled = true;
   
    shelf.GetComponent<CustomCursor>().enabled = true;
    }


private void DisableShelf(){

shelf.GetComponent<ShelfInteractive>().enabled = true;
   shelf.GetComponent<PolygonCollider2D>().enabled=false;
    shelf.GetComponent<CustomCursor>().enabled = true;
}





 private void enablePatch()
    {
      patch.GetComponent<patchinteractive>().enabled = true;
   
    patch.GetComponent<CustomCursor>().enabled = true;
    }

 private void enableTelescope()
    {
      telescope.GetComponent<telescopeinteractive>().enabled = true;
   
    telescope.GetComponent<CustomCursor>().enabled = true;
    }

private void disableTelescope()
    {
      telescope.GetComponent<telescopeinteractive>().enabled = false;
    telescope.GetComponent<PolygonCollider2D>().enabled=false;
    telescope.GetComponent<CustomCursor>().enabled = false;
    }




private void disablePatch()
    {
      patch.GetComponent<patchinteractive>().enabled = false;
   patch.GetComponent<PolygonCollider2D>().enabled=false;
    patch.GetComponent<CustomCursor>().enabled = false;
    }



 private void Enablecage()
    {
      cage.GetComponent<GeneratorInteractive>().enabled = true;
   
    cage.GetComponent<CustomCursor>().enabled = true;
    }


    private void Disablecage()
    {
      cage.GetComponent<GeneratorInteractive>().enabled = false;
   cage.GetComponent<PolygonCollider2D>().enabled=false;
    cage.GetComponent<CustomCursor>().enabled = false;
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

  private void DisableMathildaCharacter()
    {
        if (Mathilda_2 != null)
        {
            Mathilda_1.SetActive(false);
            Mathilda_2.SetActive(false);
             Mathilda_3.SetActive(false);
              Mathilda_4.SetActive(false);
               Mathilda_5.SetActive(false);
        }
    }



    public void EnableCabinet()
    {

cabinet.GetComponent<cabinetInteractive>().enabled = true;
  animator.enabled=true;
    cabinet.GetComponent<CustomCursor>().enabled = true;


    }


public void Disablecabinet(){

    cabinet.GetComponent<cabinetInteractive>().enabled = false;
    cabinet.GetComponent<PolygonCollider2D>().enabled=false;
    cabinet.GetComponent<CustomCursor>().enabled = false;
}






public void EnableGlobe()
    {

globe.GetComponent<GlobeInteractive>().enabled = true;
   
    globe.GetComponent<CustomCursor>().enabled = true;


    }

    public void Disableglobe(){
        globe.GetComponent<GlobeInteractive>().enabled = false;
    globe.GetComponent<PolygonCollider2D>().enabled=false;
    globe.GetComponent<CustomCursor>().enabled = false;
    }


    public void enableAltar()
    {

altar.GetComponent<AltarInteractive>().enabled = true;
   
    altar.GetComponent<CustomCursor>().enabled = true;


    }


public void enableCan()
    {

Can.GetComponent<CanInteractive>().enabled = true;
   
    Can.GetComponent<CustomCursor>().enabled = true;


    }


public void Enablevase()
    {

Vase.GetComponent<vaseInteractive>().enabled = true;
   
    Vase.GetComponent<CustomCursor>().enabled = true;


    }

public void Enablegenerator()
    {

Generator.GetComponent<CageInteractive>().enabled = true;
   
    Generator.GetComponent<CustomCursor>().enabled = true;


    }

public void Disablegenerator()
    {

Generator.GetComponent<CageInteractive>().enabled = false;
    Generator.GetComponent<PolygonCollider2D>().enabled=false;
    Generator.GetComponent<CustomCursor>().enabled = false;


    }











public void Disablevase()
    {

Vase.GetComponent<vaseInteractive>().enabled = false;
    Vase.GetComponent<BoxCollider2D>().enabled=false;
    Vase.GetComponent<CustomCursor>().enabled = false;


    }









public void disableCan(){

    Can.GetComponent<CanInteractive>().enabled = false;
    Can.GetComponent<BoxCollider2D>().enabled=false;
    Can.GetComponent<CustomCursor>().enabled = false;
}

public void Enableorrey()
    {

orrery.GetComponent<orreryinteractable>().enabled = true;
   
    orrery.GetComponent<CustomCursor>().enabled = true;


    }






public void Enableeffigie(){


effigie.GetComponent<effigiesInteractive>().enabled = true;
   
    effigie.GetComponent<CustomCursor>().enabled = true;

}


public void Disableeffigie(){


effigie.GetComponent<effigiesInteractive>().enabled = false;
   effigie.GetComponent<PolygonCollider2D>().enabled=false;
    effigie.GetComponent<CustomCursor>().enabled = false;


}




public void Disableorrey()
    {

orrery.GetComponent<orreryinteractable>().enabled = false;
    orrery.GetComponent<PolygonCollider2D>().enabled=false;
    orrery.GetComponent<CustomCursor>().enabled = false;


    }



public void DisableAltar()
    {

altar.GetComponent<AltarInteractive>().enabled = false;
    altar.GetComponent<PolygonCollider2D>().enabled=false;
    altar.GetComponent<CustomCursor>().enabled = false;


    }







     public void enableBurner()
    {

burner.GetComponent<BurnerInteractive>().enabled = true;
   
    burner.GetComponent<CustomCursor>().enabled = true;


    }


   public void disableBurner(){

burner.GetComponent<BurnerInteractive>().enabled = true;
    burner.GetComponent<PolygonCollider2D>().enabled=false;
    burner.GetComponent<CustomCursor>().enabled = true;


    }


 public void enableDivination()
    {

divination.GetComponent<divinationInteractive>().enabled = true;
   
    divination.GetComponent<CustomCursor>().enabled = true;


    }


public void Disabledivination()
    {

divination.GetComponent<divinationInteractive>().enabled = false;
    divination.GetComponent<PolygonCollider2D>().enabled=false;
    divination.GetComponent<CustomCursor>().enabled = false;


    }





public void enablegemStone()
    {

gemstone.GetComponent<gemstonesInteractive>().enabled = true;
   
    gemstone.GetComponent<CustomCursor>().enabled = true;


    }

public void DisablegemStone()
    {

gemstone.GetComponent<gemstonesInteractive>().enabled = false;
   gemstone.GetComponent<PolygonCollider2D>().enabled=false;
    gemstone.GetComponent<CustomCursor>().enabled = false;


    }
    
    
private void Enableletters()
    {
      letters.GetComponent<lettersInterative>().enabled = true;
   
    letters.GetComponent<CustomCursor>().enabled = true;
    }
    
private void DisableWindow()
    {
      window.GetComponent<WindowInteractive>().enabled = false;
    window.GetComponent<CustomCursor>().enabled = false;
    window.GetComponent<PolygonCollider2D>().enabled=false;
    }


    private void EnableWindow()
    {
      window.GetComponent<WindowInteractive>().enabled = true;
    window.GetComponent<CustomCursor>().enabled = true;
    window.GetComponent<PolygonCollider2D>().enabled=true;
    }
private void disableCorpse()
    {
      corpse.GetComponent<corpseInteractive>().enabled = false;
    corpse.GetComponent<CustomCursor>().enabled = false;
    corpse.GetComponent<BoxCollider2D>().enabled=false;
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
