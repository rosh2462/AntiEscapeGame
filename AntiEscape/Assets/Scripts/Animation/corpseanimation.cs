using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class corpseanimation : MonoBehaviour
{
  private Animator animator;
     
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iscorpse", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iscorpse", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.SetBool("iscorpse", true);
         //   Debug.Log("clicked");     
               

    }


}


