using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class altarAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isaltar", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isaltar", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}

