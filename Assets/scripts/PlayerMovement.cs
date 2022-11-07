using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    [SerializeField] private float moveSpeed = 5f;
    public Rigidbody2D rigidBody;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed);
    }
}
