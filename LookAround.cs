using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float Sensitivity = 100f;

    //public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    

    // Start is called before the first frame update
    void Start()
    {
        //locks the cursor in the middle
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        /*This is the script I used for the camera movement.
         * I didn't alow a full rotation, because the player can only go forward, so there is no point
         * to look back or sideways. I could have left it with no rotation at all, but I wanted to add
         * some flexibility, giving the player a slightly larger FOV. This scripts uses the movement of the cursor,
         * which is locked in the middle of the screen, in order to direct the camera.
         */

        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yRotation += mouseX;
        xRotation = Mathf.Clamp(xRotation, -10f, 10f);
        yRotation = Mathf.Clamp(yRotation, -10f, 10f);

        
       
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

       


    }
}
