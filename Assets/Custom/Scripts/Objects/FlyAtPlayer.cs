using System;
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

    // Header attribute for better organization in the Inspector
    [Header("Fly At Player Settings")]
    // Settings for flying at the player
    [SerializeField] private float flySpeed = 1f;


    /// <summary>
    /// Awake is called when the script instance is being loaded
    /// </summary>
    private void Awake()
    {
        // Initially disable the MeshRenderer to make the object invisible
        gameObject.SetActive(false);
    }

    /// <summary>
    /// Initializes the flying behavior towards the player.
    /// </summary>
    public void Start()
    {
        // Enable the MeshRenderer to make the object visible
        gameObject.GetComponent<MeshRenderer>().enabled = true;

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
    private void Update()
    {

        // Call the method to move towards the player
        MoveTowardsPlayer();
        // Destroy the object when close to the player
        DestroyWhenClose();

    }

    /// <summary>
    /// Moves the object towards the player's position.
    /// </summary>
    private void MoveTowardsPlayer()
    {
        // Move the object towards the player's position
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, flySpeed * Time.deltaTime);
    }

    /// <summary>
    /// Destroys the object when it is close enough to the player.
    /// </summary>
    private void DestroyWhenClose()
    {
        // Check the distance to the player and destroy if within threshold
        // Transform localScale.x is used as the threshold distance
        if (Vector3.Distance(transform.position, playerTransform.position) < transform.localScale.x)
        {
            // Destroy this game object
            Destroy(gameObject);
        }
    }
}
