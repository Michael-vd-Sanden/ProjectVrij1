using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    Animator triggerAnimator;
    public Animator ballAnimator;

    void Start()
    {
        triggerAnimator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        
    }

    public void pulledCable()
    {
        triggerAnimator.SetTrigger("CablePulled");
        ballAnimator.SetTrigger("CablePulled");
    }
}
