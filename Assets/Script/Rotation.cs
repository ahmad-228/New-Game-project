using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Rotation speed (Inspector se change kar sakte ho)
    public float rotationSpeed = 50f;

    void Update()
    {
        // Object ko Y-axis par rotate karega
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
