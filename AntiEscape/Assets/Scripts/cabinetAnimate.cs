using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabinetAnimate : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iscabinet", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iscabinet", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
