using UnityEngine;

/// <summary>
/// This class handles the logic when an object is hit by the player.
/// </summary>
public class ObjectHit : MonoBehaviour
{
    // Reference to the object's renderer
    private Renderer objectRenderer;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        // Get the Renderer component of the object
        objectRenderer = GetComponent<Renderer>();
    }

    /// <summary>
    /// Called when this collider/rigidbody has begun touching another rigidbody/collider.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Change the object's color to black and update its tag
            objectRenderer.material.color = Color.black;
            gameObject.tag = "HitObject";
        }
    }
}
