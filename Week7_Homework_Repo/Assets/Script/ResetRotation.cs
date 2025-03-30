using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    public GameObject targetObject;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetObjectRotation();
        }
    }

    void ResetObjectRotation()
    {
        if (targetObject != null)
        {
            targetObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}

