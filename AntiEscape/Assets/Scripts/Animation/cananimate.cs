using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cananimate : MonoBehaviour
{
   private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iscan", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iscan", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
