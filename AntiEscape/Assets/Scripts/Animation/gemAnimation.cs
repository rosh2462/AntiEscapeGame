using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gemAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isgem", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isgem", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
               animator.SetBool("isgem", true);
         //   Debug.Log("clicked");     
               

    }
}

