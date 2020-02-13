using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkSpeed;
    public float gravity = -9.8f;

    CharacterController character;
    public Vector3 moveDirection;
    private float deltaX;
    private float deltaZ;

    void Awake()
    {
        character = GetComponent<CharacterController>();   
    }

    void Update()
    {
        MoveDirection();

        float MoveX = Input.GetAxis ("Horizontal");
        float MoveZ = Input.GetAxis ("Vertical");

        character.SimpleMove((new Vector3(MoveX, 0,MoveZ).normalized) * walkSpeed);
    }

    void MoveDirection()
    {
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = transform.TransformDirection(movement);

        movement.y = gravity;
        character.Move(movement * Time.deltaTime);
    }
}
