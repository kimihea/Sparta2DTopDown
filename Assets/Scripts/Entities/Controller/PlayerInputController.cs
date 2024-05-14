﻿using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;
    protected override void Awake()
    {
        base.Awake();
        camera = CameraSingleton.GetMainCamera;
    }
    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        
    }
    public void OnLook(InputValue value)
    {
            Vector2 newAim = value.Get<Vector2>();
            Vector2 worldPos = camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(newAim);
    }
    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}
