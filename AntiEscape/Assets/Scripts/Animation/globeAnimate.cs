using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class globeAnimate : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isglobe", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isglobe", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
          animator.SetBool("isglobe", true);
         //   Debug.Log("clicked");     
               

    }
}
