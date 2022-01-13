using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimatorOverrider : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void setanimations(AnimatorOverrideController overrideController)
    { _animator.runtimeAnimatorController = overrideController; }

}
