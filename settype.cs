using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settype : MonoBehaviour
{
    [SerializeField] private AnimatorOverrideController[] overrideControllers;
    [SerializeField] private AnimatorOverrider overrider;

    public void set(int value)
    {
        overrider.setanimations(overrideControllers[value]);
    }
}
