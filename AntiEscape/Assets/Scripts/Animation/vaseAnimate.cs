using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vaseAnimate : MonoBehaviour

{
   private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isvase", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isvase", false);
        //animator.enabled=false;
    }




   public void OnMouseDown() 
    {  
          animator.SetBool("isvase", true);
         //   Debug.Log("clicked");     
               

    }
}

