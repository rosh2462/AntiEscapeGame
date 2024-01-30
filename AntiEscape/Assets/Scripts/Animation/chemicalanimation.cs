using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemicalanimation : MonoBehaviour
{
     private Animator animator;
     
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("ischemical", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("ischemical", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
          animator.SetBool("ischemical", true);
         //   Debug.Log("clicked");     
               

    }




}

