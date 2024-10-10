using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : ZepController
{
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 look = value.Get<Vector2>();
        Vector2 worldPos = _mainCamera.ScreenToWorldPoint(look);
        look = (worldPos - (Vector2)transform.position).normalized;

        CallLookEvent(look);
    }

    public void OnTalk(InputValue value)
    {
        Debug.Log("Talk");
        CallTalkEvent();
    }
}