using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepMovement : MonoBehaviour
{
    private ZepController _controller;
    private Rigidbody2D _movementRigidbody;
    private CharacterStatHandler _characterStatHandler;

    private Vector2 _movementDirection = Vector2.zero;

    private void Awake()
    {
        _controller = GetComponent<ZepController>();
        _movementRigidbody = GetComponent<Rigidbody2D>();
        _characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 dir)
    {
        _movementDirection = dir;
    }

    private void ApplyMovement(Vector2 dir)
    {
        dir = dir * _characterStatHandler.GetBaseStats().infoSO.speed;
        _movementRigidbody.velocity = dir;
    }
}