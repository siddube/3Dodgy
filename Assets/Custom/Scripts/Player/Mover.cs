using UnityEngine;

/// <summary>
/// This class is responsible for moving the player in the scene.
/// </summary>
public class Mover : MonoBehaviour
{
    // Header attribute for better organization in the Inspector
    [Header("Movement Settings")]
    // Setting for movement speed
    [SerializeField] private float moveSpeed = 10f;

    // Speed components along each axis
    private float xSpeed = 0.0f;
    private float ySpeed = 0.0f;
    private float zSpeed = 0.0f;

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    private void Update()
    {
        // Call the method to handle player movement
        MovePlayer();
    }

    /// <summary>
    /// Handles player movement based on input axes.
    /// </summary>
    private void MovePlayer()
    {
        // Calculate speed based on input and move speed
        xSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        zSpeed = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Apply translation to the player's transform
        transform.Translate(xSpeed, ySpeed, zSpeed);
    }
}
