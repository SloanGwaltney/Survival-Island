using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Vector3 movementDirection = Vector3.zero;
    private Vector3 airMovementDirection = Vector3.zero;
    private bool isGrounded = true;
    private Rigidbody rbody;
    [SerializeField] protected float lookSpeed = 30.0f;
    [SerializeField] protected float movementSpeed = 10.0f;
    [SerializeField] protected float jumpForce = 250.0f;
    [SerializeField] private Camera playerCamera;

    private void OnEnable()
    {
        rbody = GetComponent<Rigidbody>();
    }
    public void Move(InputAction.CallbackContext ctx)
    {
        Move(ctx.ReadValue<Vector2>());
    }

    public void Move(Vector2 movementVector)
    {
        airMovementDirection = new Vector3(movementVector.x, 0, movementVector.y);
        if (isGrounded)
        {
            movementDirection = new Vector3(movementVector.x, 0, movementVector.y);
            movementDirection = transform.TransformDirection(movementDirection);
            movementDirection *= movementSpeed;
            return;
        }
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            Jump();
        }
    }

    public void Jump()
    {
        if (isGrounded)
        {
            rbody.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }
    }

    protected void Update()
    {
        transform.Translate(movementDirection * Time.deltaTime);
    }

    //TODO: FIx strange stutter issue on landing
    private void OnCollisionEnter(Collision other)
    {
        // might need to check if this is a ground collision later 
        isGrounded = true;
        movementDirection = airMovementDirection;
        Debug.Log(movementDirection);
    }
}
