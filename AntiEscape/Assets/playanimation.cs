using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class playanimation : MonoBehaviour
{
    private Animator animator;

 private bool sliding = false;
    void Start()
    {
          animator = GetComponent<Animator>();
    }



    [YarnCommand("slide")]
public void Slide(string animationName) {
       
        switch (animationName)
        {
            case "Slide_Animation":
            animator.SetBool("issliding", true);
            break;

    }
}
}
