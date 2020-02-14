using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;

    CharacterController character;
    public Vector3 moveDirection;

    void Awake()
    {
        character = GetComponent<CharacterController>();   

    }

    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        character.SimpleMove((new Vector3(horizontalMovement, 0,verticalMovement ).normalized) * walkSpeed);
    }

    //void FixedUpdate()
    //{
    //    Move();   
    //}

    //void Move()
    //{
    //    //Vector3 yVelFix = new Vector3(0, rb.velocity.y, 0);
    //    character.velocity = moveDirection * walkSpeed * Time.deltaTime;
    //    //rb.velocity += yVelFix;
    //}
}
