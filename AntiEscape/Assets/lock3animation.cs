using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
public class lock3animation : MonoBehaviour
{
   private Animator animator;

 private bool islock3 = false;
    void Start()
    {
          animator = GetComponent<Animator>();
    }



[YarnCommand("lock3")]
public void Slide(string animationName) {
       
        switch (animationName)
        {
            case "lock3":
            animator.SetBool("islock3", true);
            break;

    }
}
}
