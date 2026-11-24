using UnityEngine;

using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float yRotationSpeed = 50f; // Speed of rotation around Y-axis

    void Update()
    {
        // Calculate rotation amount based on speed and time
        float yRotationAmount = yRotationSpeed * Time.deltaTime;
        // Apply rotation around Y-axis
        transform.Rotate(Vector3.up, yRotationAmount);
    }
}
