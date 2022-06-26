using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator triggerAnimator;
    public Animator ballAnimator;

    public void pulledCable()
    {
        triggerAnimator.SetTrigger("CablePulled");
        ballAnimator.SetTrigger("CablePulled");
    }
}
