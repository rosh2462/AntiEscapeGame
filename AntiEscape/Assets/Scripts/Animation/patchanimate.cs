using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patchanimate : MonoBehaviour
{
   private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("ispatch", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("ispatch", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
