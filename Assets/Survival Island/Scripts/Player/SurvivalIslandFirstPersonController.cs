using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: cache input values so that we are responding to events and not reading directly from the action map
public class SurvivalIslandFirstPersonController : FirstPersonController
{
    private PlayerInputActions inputActions;
    protected override float GetHorizontalMovement()
    {
        // Debug.Log(inputActions.Player.MoveHorizontal.ReadValue<float>());
        return inputActions.Player.MoveHorizontal.ReadValue<float>();
    }

    protected override float GetVerticalMovement()
    {
        return inputActions.Player.MoveVertical.ReadValue<float>();
    }

    protected override float GetHorizontalLook()
    {
        return inputActions.Player.Look.ReadValue<Vector2>().x;
    }

    protected override float GetVerticalLook()
    {
        return inputActions.Player.Look.ReadValue<Vector2>().y;
    }

    protected override bool IsCrouchKeyDown()
    {
        return false;
    }

    protected override bool IsJumpKeyDown()
    {
        return inputActions.Player.Jump.ReadValue<float>() == 1f;
    }

    protected override bool IsSprintKeyDown()
    {
        return false;
    }

    protected override bool IsZoomHeldDown()
    {
        return false;
    }

    protected override void PostAwake()
    {
        base.PostAwake();
        inputActions = new PlayerInputActions();
        inputActions.Player.Enable();
    }
}
