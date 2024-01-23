using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telescopeanimation : MonoBehaviour
{
   
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("istelescope", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("istelescope", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
