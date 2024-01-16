using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantanimate : MonoBehaviour
{
     private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isplant", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isplant", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
