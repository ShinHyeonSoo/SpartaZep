using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator _animator;
    protected ZepController _controller;

    protected virtual void Awake()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponentInParent<ZepController>();
    }
}
