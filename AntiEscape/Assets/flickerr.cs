using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flickerr : MonoBehaviour
{
  public Yarn.Unity.DialogueRunner runner;
 
 public GameObject blackout;
  private Animator animator;
    void Start()
    {
        runner.AddCommandHandler("flickerlights1", Flickerlight);
        runner.AddCommandHandler("endflickerlights1",FlickerEndlight);
         
        animator = GetComponent<Animator>();
    }
    
    public void Flickerlight()
    {

        
       
       animator.enabled=true;
      animator.SetBool("isplayed",true);
      Debug.Log("Played Start");
           
             
        }





         public void FlickerEndlight()
    {

blackout.GetComponent<SpriteRenderer>().enabled = false;
  animator.enabled=false;
   Debug.Log("Played End");

    }


}

 



