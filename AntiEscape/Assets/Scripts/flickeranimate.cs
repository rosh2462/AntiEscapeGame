using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class flickeranimate : MonoBehaviour
{
public Yarn.Unity.DialogueRunner runner;
 
 public GameObject blackout;
  private Animator animator;
    void Start()
    {
        runner.AddCommandHandler("flicker", Flicker);
        runner.AddCommandHandler("endflicker",FlickerEnd);
        animator = GetComponent<Animator>();
    }
    
    public void Flicker()
    {

        
       
       animator.enabled=true;
      animator.SetBool("isplayed",true);
      Debug.Log("Played Start");
           
             
        }

         public void FlickerEnd()
    {

blackout.GetComponent<SpriteRenderer>().enabled = false;
  animator.enabled=false;
   Debug.Log("Played End");

    }
    
    
}




