using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windowanimate : MonoBehaviour
{
   private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iswindow", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iswindow", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
