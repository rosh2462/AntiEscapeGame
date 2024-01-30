using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lettersanimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("isletter", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("isletter", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
          animator.SetBool("isletter", true);
         //   Debug.Log("clicked");     
               

    }
}
