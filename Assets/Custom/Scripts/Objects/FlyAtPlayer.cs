using UnityEngine;

/// <summary>
/// This class is responsible for making an object fly towards the player.
/// </summary>
public class FlyAtPlayer : MonoBehaviour
{
    // Header attribute for better organization in the Inspector
    [Header("Fly At Player Components")]
    // Reference to the player's transform
    [SerializeField] private Transform playerTransform;

    // Settings for flying at the player
    [Header("Fly At Player Settings")]
    [SerializeField] private float flySpeed = 1f;

    /// <summary>
    /// Awake is called when the script instance is being loaded
    /// </summary>
    private void Awake()
    {
        // If playerTransform is not assigned, try to find the player in the scene
        if (playerTransform == null)
        {
            // Find the player object by tag if not assigned
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            // If found, assign its transform
            // Else, log a warning
            if (player != null)
            {
                playerTransform = player.transform;
            }
            else
            {
                Debug.LogWarning("Player object not found in the scene. Please assign the playerTransform manually.");
            }
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, flySpeed * Time.deltaTime);
    }
}
