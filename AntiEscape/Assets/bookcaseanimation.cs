using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookcaseanimation : MonoBehaviour
{
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isbook", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isbook", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
