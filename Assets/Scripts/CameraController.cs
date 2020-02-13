using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float mousesensitivity;

    float xAxisClamp = 0;

    [SerializeField]
    Transform player, playerArms;

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mousesensitivity;
        float rotAmountY = mouseY * mousesensitivity;

        xAxisClamp -= rotAmountY;

        Vector3 rotPlayersArms = playerArms.transform.rotation.eulerAngles;
        Vector3 rotPlayer = player.transform.rotation.eulerAngles;

        rotPlayersArms.x -= rotAmountY;
        rotPlayersArms.z = 0;
        rotPlayer.y += rotAmountX;

        if(xAxisClamp > 90)
        {
            xAxisClamp = 90;
            rotPlayersArms.x = 90;
        }
        else if(xAxisClamp < -90)
        {
            xAxisClamp = -90;
            rotPlayersArms.x = 270;
        }

        playerArms.rotation = Quaternion.Euler(rotPlayersArms);
        player.rotation = Quaternion.Euler(rotPlayer);
    }
}
