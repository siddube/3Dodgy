using UnityEngine;

/// <summary>
/// This class is responsible for triggering a projectile in the scene.
/// </summary>
public class TriggerProjectile : MonoBehaviour
{
    // Header attribute for better organization in the Inspector
    [Header("Projectile Components")]
    // Reference to the projectile GameObject
    [SerializeField] private GameObject projectile;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        // Check if the triggering object has the "Player" tag
        if (other.gameObject.CompareTag("Player"))
        {
            // Initialize the projectile's flying behavior towards the player
            projectile.SetActive(true);
        }

        // Disable this trigger to prevent multiple activations
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
}
