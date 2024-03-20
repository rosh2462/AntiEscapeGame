using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class lock4animation : MonoBehaviour
{
   private Animator animator;

 private bool islock4 = false;
    void Start()
    {
          animator = GetComponent<Animator>();
    }



[YarnCommand("lock4")]
public void Slide(string animationName) {
       
        switch (animationName)
        {
            case "lock4":
            animator.SetBool("islock4", true);
            break;

    }
}
}
