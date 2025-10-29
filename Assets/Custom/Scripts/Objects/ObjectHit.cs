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
        objectRenderer = GetComponent<Renderer>();
    }

    /// <summary>
    /// Called when this collider/rigidbody has begun touching another rigidbody/collider.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            objectRenderer.material.color = Color.black;
            gameObject.tag = "HitObject";
        }
    }
}
