using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolanimate : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("istool", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("istool", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
