using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnerAnimation : MonoBehaviour
{
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isburner", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isburner", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}

