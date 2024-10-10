using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepRotation : MonoBehaviour
{
    private SpriteRenderer _sprRenderer;
    private ZepController _controller;

    private void Awake()
    {
        _sprRenderer = GetComponentInChildren<SpriteRenderer>();
        _controller = GetComponent<ZepController>();
    }

    private void Start()
    {
        _controller.OnLookEvent += Look;
    }

    private void Look(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        _sprRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}
