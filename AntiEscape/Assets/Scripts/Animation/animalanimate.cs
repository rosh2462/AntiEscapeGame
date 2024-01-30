using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalanimate : MonoBehaviour
{
//test

    private Animator animator;
     
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("ishover", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("ishover", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
        animator.SetBool("ishover", true);
         //   animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }




}
