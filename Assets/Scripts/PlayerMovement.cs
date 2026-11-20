using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    private Vector2 moveDirection;
    private GameObject collisionObject;
    
    public void OnMove(InputValue value)
    {
        moveDirection = value.Get<Vector2>();
        //print(moveDirection); debug
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        collisionObject = other.gameObject;
    }

    public void FixedUpdate()
    {
            Move(collisionObject);
    }

    private void Move(GameObject collisionObject)
    {
        if (collisionObject == null) return;
        
        if (collisionObject.CompareTag("Ground"))
        {
            rigidbody2D.AddForce(moveDirection * GameParameters.playerSpeed);
        }
    }
}
