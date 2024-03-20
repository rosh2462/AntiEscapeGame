using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class lock2animation : MonoBehaviour
{
      private Animator animator;

 private bool islock2 = false;
    void Start()
    {
          animator = GetComponent<Animator>();
    }



[YarnCommand("lock2")]
public void Slide(string animationName) {
       
        switch (animationName)
        {
            case "lock2":
            animator.SetBool("islock2", true);
            break;

    }
}
}
