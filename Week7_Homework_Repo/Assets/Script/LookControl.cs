using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookControl : MonoBehaviour
{
    
    public float MouseSensitivity = 200.0f;
    
    float CameraX = 0.0f;
    
    float CameraXMax = 60f;
    float CameraXMin = -60f;

    
    public Transform playerT=null;

    private void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * MouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * MouseSensitivity;


        
        CameraX -= mouseY;   
        
        CameraX = Mathf.Clamp(CameraX, CameraXMin, CameraXMax);
        
        transform.localRotation = Quaternion.Euler(CameraX, 0, 0);

        
        if(playerT != null)
        {
            playerT.Rotate(playerT.up, mouseX);
        }

        

    }
}
