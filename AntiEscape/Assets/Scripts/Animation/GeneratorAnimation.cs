using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isgenerator", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isgenerator", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}

