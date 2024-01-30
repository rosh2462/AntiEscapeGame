using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effigiesAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iseffigies", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iseffigies", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.SetBool("iseffigies", true);
         //   Debug.Log("clicked");     
               

    }
}


