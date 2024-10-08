using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;
    public event Action OnTalkEvent;

    public void CallMoveEvent(Vector2 dir)
    {
        OnMoveEvent?.Invoke(dir);
    }

    public void CallLookEvent(Vector2 dir)
    {
        OnLookEvent?.Invoke(dir);
    }

    public void CallTalkEvent()
    {
        OnTalkEvent?.Invoke();
    }
}