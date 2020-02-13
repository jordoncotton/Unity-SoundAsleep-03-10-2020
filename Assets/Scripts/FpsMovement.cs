using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FpsMovement : MonoBehaviour
{
    [SerializeField] private Camera headCam;

    public float speed = 6.0f;
    public float gravity = -9.8f;

    public float sensitivityHor = 9.0f;
    public float sensitivityVert = 9.0f;

    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;

    private float rotationVert = 0;

    private CharacterController charController;

    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    void Update()
    {
        MoveCharacter();
        RotateCharacter();
        RotateCamera();
    }

    private void MoveCharacter()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = transform.TransformDirection(movement);
        //movement = Vector3.ClampMagnitude(movement, speed);
      
        movement.y -= gravity;
        charController.Move(movement * Time.deltaTime);
    }

    private void RotateCharacter()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
    }

    private void RotateCamera()
    {
        rotationVert -= Input.GetAxis("Mouse Y") * sensitivityVert;
        rotationVert = Mathf.Clamp(rotationVert, minimumVert, maximumVert);

        headCam.transform.localEulerAngles = new Vector3(
            rotationVert, headCam.transform.localEulerAngles.y, 0
        );
    }
}
