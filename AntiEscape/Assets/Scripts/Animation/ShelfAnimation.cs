using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfAnimation : MonoBehaviour
{
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isshelf", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isshelf", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.SetBool("isshelf", true);
         //   Debug.Log("clicked");     
               

    }
}


