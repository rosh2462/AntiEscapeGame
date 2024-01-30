using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class divinationAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isdivination", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isdivination", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
           animator.SetBool("isdivination", true);
         //   Debug.Log("clicked");     
               

    }
}
