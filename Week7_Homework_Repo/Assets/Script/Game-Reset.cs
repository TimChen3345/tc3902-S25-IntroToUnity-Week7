using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResetManager : MonoBehaviour
{
    // Optional: Add references to objects or variables you want to reset manually
    public int playerScore = 0;
    public Vector3 playerStartPosition;
    public GameObject player;

    // Target object and range for the 'F' key reset
    public GameObject targetObject;
    public float resetRange = 5.0f;

    void Start()
    {
        // Save the initial state of objects or variables
        if (player != null)
        {
            playerStartPosition = player.transform.position;
        }
    }

    void Update()
    {
        // Check if the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }

        // Check if the 'F' key is pressed and the player is within range of the target
        if (Input.GetKeyDown(KeyCode.F) && IsPlayerInRange())
        {
            ResetGame();
        }
    }

    void ResetGame()
    {
        // Option 1: Reload the scene to reset everything
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Option 2: Manually reset objects or variables (if needed)
        if (player != null)
        {
            player.transform.position = playerStartPosition;
            // Reset other player properties as needed, e.g., health, score
        }

        playerScore = 0; // Reset score or other global variables
    }

    bool IsPlayerInRange()
    {
        if (player != null && targetObject != null)
        {
            float distance = Vector3.Distance(player.transform.position, targetObject.transform.position);
            return distance <= resetRange;
        }
        return false;
    }
}
