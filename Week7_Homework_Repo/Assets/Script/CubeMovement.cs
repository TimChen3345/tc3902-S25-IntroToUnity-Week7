using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the cube

    void Update()
    {
        // Get input from WASD keys
        float moveHorizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveVertical = Input.GetAxis("Vertical"); // W/S or Up/Down

        // Create a movement vector based on input
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical) * moveSpeed * Time.deltaTime;

        // Apply the movement to the cube's position
        transform.Translate(movement);
    }
}
