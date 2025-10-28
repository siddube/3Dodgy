using UnityEngine;

/// <summary>
/// Handles scoring when the player collides with certain objects.
/// </summary>
public class Scorer : MonoBehaviour
{
    // Number of hits recorded
    private int hits = 0;

    /// <summary>
    /// Called when the player collides with another object.
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter(Collision other)
    {
        // Increment hit count and log the event
        hits++;
        Debug.Log($"Player hit the objects {hits} times");
    }
}
