using UnityEngine;

/// <summary>
/// This class is responsible for spinning an object in the scene.
/// </summary>
public class Spinner : MonoBehaviour
{
    // Header attribute for better organization in the Inspector
    [Header("Spinner Settings")]
    // Setting for rotation speed
    [SerializeField] private float rotateSpeed = 10f;

    // Angle components along each axis
    [SerializeField] private float xAngle = 0.0f;
    [SerializeField] private float yAngle = 0.0f;
    [SerializeField] private float zAngle = 0.0f;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
