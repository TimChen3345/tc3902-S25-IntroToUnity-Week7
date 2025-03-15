using UnityEngine;

public class ZoomOnRightClick : MonoBehaviour
{
    [Header("Zoom Settings")]
    public float zoomFOV = 30f;       // Field of view when zoomed in
    public float zoomSpeed = 10f;    // Speed of the zoom effect
    public float normalFOV = 60f;    // Default field of view

    private Camera cameraComponent;

    void Start()
    {
        // Get the Camera component
        cameraComponent = GetComponent<Camera>();

        if (cameraComponent == null)
        {
            Debug.LogError("No Camera component found on this GameObject!");
        }
    }

    void Update()
    {
        if (cameraComponent != null)
        {
            if (Input.GetMouseButton(1)) // Right mouse button is held down
            {
                // Smoothly transition to the zoom FOV
                cameraComponent.fieldOfView = Mathf.Lerp(cameraComponent.fieldOfView, zoomFOV, zoomSpeed * Time.deltaTime);
            }
            else
            {
                // Smoothly transition back to the normal FOV
                cameraComponent.fieldOfView = Mathf.Lerp(cameraComponent.fieldOfView, normalFOV, zoomSpeed * Time.deltaTime);
            }
        }
    }
}
