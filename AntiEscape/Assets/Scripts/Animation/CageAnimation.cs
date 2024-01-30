using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageAnimation : MonoBehaviour
{
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iscage", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iscage", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.SetBool("iscage", true);
         //   Debug.Log("clicked");     
               

    }
}



