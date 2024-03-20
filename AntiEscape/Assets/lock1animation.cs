using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;


public class lock1animation : MonoBehaviour
{
      private Animator animator;

 private bool islock1 = false;
    void Start()
    {
          animator = GetComponent<Animator>();
    }



[YarnCommand("lock")]
public void Slide(string animationName) {
       
        switch (animationName)
        {
            case "lock1":
            animator.SetBool("islock1", true);
            break;

    }
}
}
