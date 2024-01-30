using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orreryanimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isorrery", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isorrery", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
           animator.SetBool("isorrery", true);
         //   Debug.Log("clicked");     
               

    }
}
