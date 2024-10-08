using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepAnimationController : AnimationController
{
    private static readonly int _isWalking = Animator.StringToHash("isWalking");
    private static readonly int _talk = Animator.StringToHash("talk");

    private readonly float _magnituteThreshold = 0.5f;

    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnTalkEvent += Talk;
    }

    private void Move(Vector2 obj)
    {
        _animator.SetBool(_isWalking, obj.magnitude > _magnituteThreshold);
    }

    private void Talk()
    {
        _animator.SetTrigger(_talk);
    }
}
