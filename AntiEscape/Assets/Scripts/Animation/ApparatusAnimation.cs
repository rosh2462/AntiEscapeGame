using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparatusAnimation : MonoBehaviour
{
//test

    private Animator animator;
     
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isapparatus", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isapparatus", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
           animator.SetBool("isapparatus", true);
         //   Debug.Log("clicked");     
               

    }




}

