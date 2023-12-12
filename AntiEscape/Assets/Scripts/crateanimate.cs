using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crateanimate : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;
    void Start()
    {
          animator = GetComponent<Animator>();
    }

      private void OnMouseOver()
    {
        
        animator.SetBool("iscrate", true);
    }

    private void OnMouseExit()
    {
        
        animator.SetBool("iscrate", false);
        //animator.enabled=false;
    }




    public void OnMouseDown() 
    {  
            animator.enabled=false;
         //   Debug.Log("clicked");     
               

    }
}
